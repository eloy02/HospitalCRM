using HospitalCRM.Core.Model;
using MediatR;
using ProtoBuf;

namespace HospitalCRM.Core.ServicesContracts.PacientsService.Queries;

[ProtoContract(SkipConstructor = true)]
public class GetPacientsQuery : IRequest<IEnumerable<Pacient>>
{
    public GetPacientsQuery(string fioSearch = null)
    {
        FioSearch = fioSearch;
    }

    [ProtoMember(1)] public string FioSearch { get; set; }
}