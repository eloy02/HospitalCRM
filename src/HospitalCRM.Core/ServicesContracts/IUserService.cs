using HospitalCRM.Core.Model;
using HospitalCRM.Core.Model.Requests;
using ProtoBuf.Grpc.Configuration;

namespace HospitalCRM.Core.ServicesContracts;

[Service]
public interface IUserService
{
    [Operation]
    ValueTask<Response<string>> AuthorizeUser(Request<AuthRequest> authRequest);

    [Operation]
    ValueTask<Response<IEnumerable<User>>> GetUsers(Request usersRequest);
}