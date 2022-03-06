using MediatR;
using ProtoBuf;

namespace HospitalCRM.Core.ServicesContracts;

[ProtoContract]
public sealed class Request<T> where T : IBaseRequest
{
    public static Request<T> Create(T data, string jwt)
    {
        return new Request<T>
        {
            Data = data,
            UserKey = jwt
        };
    }


    [ProtoMember(1,
        Options = MemberSerializationOptions.DynamicType,
        IsRequired = true,
        DynamicType = true)]
    public T Data { get; set; }

    [ProtoMember(2)] public string UserKey { get; set; }
}

[ProtoContract]
public class Request
{
    public static Request Create(string jwt)
    {
        return new Request
        {
            UserKey = jwt
        };
    }

    [ProtoMember(1)] public string UserKey { get; set; }
}