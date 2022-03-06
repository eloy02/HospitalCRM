using HospitalCRM.Core.Model;
using MediatR;
using ProtoBuf;

namespace HospitalCRM.Core.ServicesContracts.UserService.Commands;

[ProtoContract(SkipConstructor = true)]
public class AuthUserCommand : IRequest<string>
{
    public AuthUserCommand(User user, string password)
    {
        User = user ?? throw new ArgumentNullException(nameof(user));
        Password = password ?? throw new ArgumentNullException(nameof(password));
    }

    [ProtoMember(1)] public User User { get; set; }

    [ProtoMember(2)] public string Password { get; set; }
}