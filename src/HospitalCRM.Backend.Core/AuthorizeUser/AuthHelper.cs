using HospitalCRM.Backend.Core.Database;
using HospitalCRM.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace HospitalCRM.Backend.Core.AuthorizeUser;

public static class AuthHelper
{
    /// <summary>
    ///     Authorize user. If failed returns empty jwt token
    /// </summary>
    /// <param name="context"></param>
    /// <param name="userId"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public static async Task<string> AuthorizeUser(this DataContext context, long userId, string password)
    {
        if (string.IsNullOrWhiteSpace(password))
            return string.Empty;

        var user = await context.Users
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == userId && x.IsActive);

        return user is null ? string.Empty : JwtHelper.GenerateToken(user);
    }

    /// <summary>
    /// Identify user from jwt token
    /// </summary>
    /// <param name="context"></param>
    /// <param name="jwtToken"></param>
    /// <returns></returns>
    public static async Task<User?> IdentifyUser(this DataContext context, string jwtToken)
    {
        if (string.IsNullOrWhiteSpace(jwtToken))
            return null;

        return await context.Users
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == JwtHelper.ValidateToken(jwtToken));
    }
}