using System.Security.Claims;

namespace SureCompli.Token
{
    public interface ITokenSupportService
    {
        ClaimsPrincipal GetPrincipal(string token);
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}