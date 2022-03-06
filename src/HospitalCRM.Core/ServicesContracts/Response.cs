using HospitalCRM.Core.Model;
using ProtoBuf;

namespace HospitalCRM.Core.ServicesContracts;

[ProtoContract]
public class Response<T> where T : class
{
    [ProtoMember(1,
        Options = MemberSerializationOptions.DynamicType,
        DynamicType = true,
        IsRequired = false)]
    public T? Data { get; set; }

    [ProtoMember(2)] public bool IsSuccess { get; set; }

    [ProtoMember(3)] public string Message { get; set; }

    [ProtoMember(4)] public User User { get; set; }
}

[ProtoContract]
public class Response
{
    [ProtoMember(1)] public bool IsSuccess { get; set; }

    [ProtoMember(2)] public string Message { get; set; }

    [ProtoMember(3)] public User User { get; set; }
}