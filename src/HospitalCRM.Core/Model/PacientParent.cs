using ProtoBuf;

namespace HospitalCRM.Core.Model;

[ProtoContract]
public sealed class PacientParent : IPersonBase
{
    [ProtoMember(1)]
    public long Id { get; set; }
    
    [ProtoMember(2)]
    public long PacientId { get; set; }
    
    [ProtoMember(3)]
    public string FirstName { get; set; }
    
    [ProtoMember(4)]
    public string LastName { get; set; }
    
    [ProtoMember(5)]
    public string? PatronymicName { get; set; }
    
    [ProtoMember(6)]
    public string PhoneNumber { get; set; }

    public string FullName => $"{LastName} {FirstName} {PatronymicName}";

    [ProtoMember(7)]
    public Pacient Pacient { get; set; }
}