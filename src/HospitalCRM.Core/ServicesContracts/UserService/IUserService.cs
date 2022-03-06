using HospitalCRM.Core.Model;
using HospitalCRM.Core.ServicesContracts.UserService.Commands;
using HospitalCRM.Core.ServicesContracts.UserService.Queries;
using ProtoBuf.Grpc.Configuration;

namespace HospitalCRM.Core.ServicesContracts.UserService;

[Service]
public interface IUserService
{
    [Operation]
    ValueTask<Response<string>> AuthorizeUser(Request<AuthUserCommand> authRequest);

    [Operation]
    ValueTask<Response<IEnumerable<User>>> GetUsers(Request<GetUsersQuery> usersRequest);
}