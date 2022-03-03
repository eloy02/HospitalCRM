using ProtoBuf;

namespace HospitalCRM.Core.Model;

[ProtoContract]
public sealed class DoctorPosition
{
    [ProtoMember(1)]
    public long Id { get; set; }
    
    [ProtoMember(2)]
    public string Name { get; set; }
}