using HospitalCRM.Core.Model;
using MediatR;
using ProtoBuf;

namespace HospitalCRM.Core.ServicesContracts.PacientsService.Queries;

[ProtoContract(SkipConstructor = true)]
public class GetPacientsQuery : IRequest<IEnumerable<Pacient>>
{
    public GetPacientsQuery(
        bool loadParents = false,
        bool loadDocuments = false,
        string fioSearch = "")
    {
        LoadParents = loadParents;
        LoadDocuments = loadDocuments;
        FioSearch = fioSearch;
    }

    
    [ProtoMember(1)] public string FioSearch { get; set; }
    [ProtoMember(2)] public bool LoadParents { get; set; }
    [ProtoMember(3)] public bool LoadDocuments { get; set; }
}