using HospitalCRM.Core.Model;
using MediatR;
using ProtoBuf;

namespace HospitalCRM.Core.ServicesContracts.PacientsService.Queries;

[ProtoContract(SkipConstructor = true)]
public class GetPacientsVisitsQuery : IRequest<IEnumerable<PacientVisit>>
{
    public GetPacientsVisitsQuery(long pacientId)
    {
        PacientId = pacientId;
    }

    public long PacientId { get; set; }
}