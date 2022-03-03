using ProtoBuf;

namespace HospitalCRM.Core.Model;

[ProtoContract]
public sealed class PacientDocument
{
    [ProtoMember(1)]
    public long Id { get; set; }
    
    [ProtoMember(2)]
    public long PacientId { get; set; }
    
    [ProtoMember(3)]
    public byte[] Data { get; set; }
}