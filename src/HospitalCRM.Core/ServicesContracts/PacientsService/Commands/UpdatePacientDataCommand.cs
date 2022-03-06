using HospitalCRM.Core.Model;
using MediatR;
using ProtoBuf;

namespace HospitalCRM.Core.ServicesContracts.PacientsService.Commands;

[ProtoContract(SkipConstructor = true)]
public class UpdatePacientDataCommand : IRequest
{
    public UpdatePacientDataCommand(long pacientId, Pacient pacient)
    {
        PacientId = pacientId;
        Pacient = pacient ?? throw new ArgumentNullException(nameof(pacient));
    }

    [ProtoMember(1)] public long PacientId { get; set; }

    [ProtoMember(2)] public Pacient Pacient { get; set; }
}