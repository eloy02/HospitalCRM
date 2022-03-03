using ProtoBuf;

namespace HospitalCRM.Core.Model.Requests;

[ProtoContract]
public sealed class PacientVisitRequest
{
    [ProtoMember(1)]
    public long PacientId { get; set; }
}