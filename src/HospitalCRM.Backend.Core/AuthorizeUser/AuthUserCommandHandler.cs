using HospitalCRM.Backend.Core.Database;
using HospitalCRM.Core.ServicesContracts.UserService.Commands;
using MediatR;

namespace HospitalCRM.Backend.Core.AuthorizeUser;

public sealed class AuthUserCommandHandler : IRequestHandler<AuthUserCommand, string>
{
    private DataContext _context;

    public AuthUserCommandHandler(DataContext context)
    {
        _context = context;
    }

    public async Task<string> Handle(AuthUserCommand request, CancellationToken cancellationToken)
    {
        return await _context.AuthorizeUser(request.User.Id, request.Password);
    }
}