using HospitalCRM.Core.Model;
using MediatR;
using ProtoBuf;

namespace HospitalCRM.Core.ServicesContracts.PacientsService.Commands;

[ProtoContract(SkipConstructor = true)]
public class AddPacientCommand : IRequest
{
    public AddPacientCommand(Pacient newPacient)
    {
        NewPacient = newPacient;
    }

    [ProtoMember(1)] public Pacient NewPacient { get; set; }
}