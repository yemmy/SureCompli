using System.Security.Claims;

namespace SureCompli.BlockChain
{
    public interface IBlockChainCommunications
    {
        ClaimsPrincipal CreateAccount(string ac);
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}