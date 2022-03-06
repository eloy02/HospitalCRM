using MediatR;
using ProtoBuf;

namespace HospitalCRM.Core.ServicesContracts.UserService.Queries;

[ProtoContract(SkipConstructor = true)]
public class GetUsersQuery : IRequest<IEnumerable<Request>>
{
}