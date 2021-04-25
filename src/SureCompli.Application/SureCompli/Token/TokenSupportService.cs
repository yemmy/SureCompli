using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace SureCompli.Token
{
    [RemoteService(false,IsMetadataEnabled =false)]
    public class TokenSupportService : ApplicationService, ITokenSupportService, IApplicationService
    {
        public TokenSupportService()
        {

        }
        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            RSAParameters rSAParameters = SureCompliConsts.RSAParameters;
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new RsaSecurityKey(rSAParameters),//new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:SecretKey"])),
                ValidateLifetime = false
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");

            return principal;
        }

        public ClaimsPrincipal GetPrincipal(string token)
        {
            try
            {
                RSAParameters rSAParameters = SureCompliConsts.RSAParameters;
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
                if (jwtToken == null) return null;
                TokenValidationParameters parameters = new TokenValidationParameters()
                {
                    RequireExpirationTime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new RsaSecurityKey(rSAParameters) // new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:SecretKey"]))
                };
                SecurityToken securityToken;
                ClaimsPrincipal principal = tokenHandler.ValidateToken(token, parameters, out securityToken);
                return principal;
            }
            catch
            {
                return null;
            }
        }

    }
}
