using ProtoBuf;

namespace HospitalCRM.Core.Model.Requests;

[ProtoContract]
public sealed class AuthRequest
{
    [ProtoMember(1)] public User User { get; set; }

    [ProtoMember(2)] public string Password { get; set; }
}