using ProtoBuf;

namespace HospitalCRM.Core.Model;

[ProtoContract]
public sealed class User : IPersonBase
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
    public bool IsActive { get; set; }
    
    [ProtoMember(6)]
    public UserType UserType { get; set; }
    
    [ProtoMember(7)]
    public string Password { get; set; }
    public string FullName => $"{LastName} {FirstName} {PatronymicName}";
}

[ProtoContract]
public enum UserType
{
    [ProtoEnum] Hospital = 1,

    [ProtoEnum] RehabilitationCenter = 2,

    [ProtoEnum] Administrator = 3
}