using HospitalCRM.Backend.Core.Database;
using HospitalCRM.Core.Model;
using HospitalCRM.Core.ServicesContracts.PacientsService.Commands;
using MediatR;

namespace HospitalCRM.Backend.Core.QueryCommandsHandlers.PacientsService;

public sealed class AddPacientCommandHandler : QueryCommandsHandlerBase, IRequestHandler<AddPacientCommand>
{
    public AddPacientCommandHandler(DataContext context) : base(context)
    {
    }

    public async Task<Unit> Handle(AddPacientCommand request, CancellationToken cancellationToken)
    {
        var newPacient = new Pacient()
        {
            FirstName = request.NewPacient.FirstName,
            LastName = request.NewPacient.LastName,
            PatronymicName = request.NewPacient.PatronymicName,
            City = request.NewPacient.City,
            Street = request.NewPacient.Street,
            BuildingNumber = request.NewPacient.BuildingNumber,
            FlatNumber = request.NewPacient.FlatNumber,
            PhoneNumber = request.NewPacient.PhoneNumber,
            IsChild = request.NewPacient.IsChild
        };

        _context.Pacients.Add(newPacient);
        await _context.SaveChangesAsync(cancellationToken);

        foreach (var parent in newPacient.Parents)
        {
            parent.PacientId = newPacient.Id; 
            _context.PacientParents.Add(parent);
        }

        foreach (var document in newPacient.Documents)
        {
            document.PacientId = newPacient.Id;
            _context.PacientDocuments.Add(document);
        }

        await _context.SaveChangesAsync(cancellationToken);

        return new Unit();
    }
}