using ProtoBuf;

namespace HospitalCRM.Core.Model;

[ProtoContract]
public sealed class Doctor : IPersonBase
{
    [ProtoMember(1)]
    public long Id { get; set; }
    
    [ProtoMember(2)]
    public string FirstName { get; set; }
    
    [ProtoMember(3)]
    public string LastName { get; set; }
    
    [ProtoMember(4)]
    public string PatronymicName { get; set; }
    
    [ProtoMember(5)]
    public DoctorPosition Position { get; set; }
    
    [ProtoMember(6)]
    public bool IsActive { get; set; }

    public string FullName => $"{LastName} {FirstName} {PatronymicName}";

    [ProtoMember(7)] public long PositionId { get; set; }

    [ProtoMember(8)] public List<PacientVisit> PacientVisits { get; set; }
}
