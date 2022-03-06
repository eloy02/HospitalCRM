using ProtoBuf;

namespace HospitalCRM.Core.Model;

[ProtoContract]
public sealed class Pacient : IPersonBase
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
    public string City { get; set; }
    
    [ProtoMember(6)]
    public string Street { get; set; }
    
    [ProtoMember(7)]
    public string BuildingNumber { get; set; }
    
    [ProtoMember(8)]
    public string FlatNumber { get; set; }
    
    [ProtoMember(9)]
    public string PhoneNumber { get; set; }
    
    [ProtoMember(10)]
    public bool IsChild { get; set; }
    
    [ProtoMember(11)]
    public List<PacientParent> Parents { get; set; }
    
    [ProtoMember(12)]
    public List<PacientDocument> Documents { get; set; }

    [ProtoMember(13)] public List<PacientVisit> Visits { get; set; }

    public string FullName => $"{LastName} {FirstName} {PatronymicName}";
}