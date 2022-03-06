using HospitalCRM.Core.Model;
using MediatR;
using ProtoBuf;

namespace HospitalCRM.Core.ServicesContracts.PacientsService.Commands;

[ProtoContract(SkipConstructor = true)]
public class CreatePacientVisitCommand : IRequest
{
    public CreatePacientVisitCommand(Pacient pacient, Doctor doctor)
    {
        Pacient = pacient;
        Doctor = doctor;
    }

    [ProtoMember(1)] public Pacient Pacient { get; set; }

    [ProtoMember(2)] public Doctor Doctor { get; set; }
}