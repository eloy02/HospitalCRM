using HospitalCRM.Backend.Core.Database;
using HospitalCRM.Core.Model;
using HospitalCRM.Core.ServicesContracts.PacientsService.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HospitalCRM.Backend.Core.QueryCommandsHandlers.PacientsService;

public sealed class GetPacientsQueryHandler : QueryCommandsHandlerBase,
    IRequestHandler<GetPacientsQuery, IEnumerable<Pacient>>
{
    public GetPacientsQueryHandler(DataContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Pacient>> Handle(GetPacientsQuery request, CancellationToken cancellationToken)
    {
        var pacientsQuery = _context.Pacients
            .AsNoTracking();

        if (request.LoadParents)
            pacientsQuery = pacientsQuery.Include(x => x.Parents);

        if (request.LoadDocuments)
            pacientsQuery = pacientsQuery.Include(x => x.Documents);

        var loop = pacientsQuery.AsAsyncEnumerable();

        if (!string.IsNullOrWhiteSpace(request.FioSearch))
            loop = loop.Where(x => x.FullName.ToLower().Contains(request.FioSearch.ToLower()));

        return await loop.ToListAsync(cancellationToken);
    }
}