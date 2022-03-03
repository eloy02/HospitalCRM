using ProtoBuf;

namespace HospitalCRM.Core.Model;

[ProtoContract]
public sealed class PacientVisit
{
    [ProtoMember(1)]
    public long Id { get; set; }
    
    [ProtoMember(2)]
    public Pacient Pacient { get; set; }
    
    [ProtoMember(3)]
    public Doctor Doctor { get; set; }
    
    [ProtoMember(4,  DataFormat = DataFormat.WellKnown)]
    public DateTimeOffset VisitDate { get; set; }
}