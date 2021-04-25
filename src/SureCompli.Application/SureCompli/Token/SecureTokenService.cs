using SureCompli.Token;
using IdentityModel.Client;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Newtonsoft.Json.Linq;

namespace SureCompli.Token
{
    public class SecureTokenService : ApplicationService, ISecureTokenService,IApplicationService
    {
        private readonly IConfiguration _configuration;
        private readonly ITokenSupportService _tokenSupportService;

        public SecureTokenService(IConfiguration configuration, ITokenSupportService tokenSupportService)
        {
            _configuration = configuration;
            _tokenSupportService = tokenSupportService;
        }

        [HttpPost]
        public string PostAccessToken(Dictionary<string, string> input)
        {
            IEnumerable<Claim> claims = new List<Claim>();
            RSAParameters rSAParameters = SureCompliConsts.RSAParameters;

            var jwtToken = new JwtSecurityToken(issuer: _configuration["AuthServer:Issuer"],
                audience: _configuration["AuthServer:Audience"],
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddMinutes(int.Parse(_configuration["AuthServer:TokenExpiry"])),
                signingCredentials: new SigningCredentials(new RsaSecurityKey(rSAParameters), SecurityAlgorithms.RsaSha256Signature)
            );
            return new JwtSecurityTokenHandler().WriteToken(jwtToken);

        }

        [HttpPost]
        public JObject PostToken()
        {

            //throw new NotImplementedException();
            string url = "https://localhost:44328";
            var client = new HttpClient();
            var tokenResponse = client.RequestPasswordTokenAsync(new PasswordTokenRequest
            {
                RequestUri = new Uri($"{url}/connect/token"),
                UserName = "admin",
                Password = "Test@123",
                ClientId = "BioSwitch_App",
                ClientSecret = "1q2w3e*"
            }).Result;

            return tokenResponse.Json;
        }

        [HttpPost]
        public string PostRefreshToken()
        {
            var randomNumber = new byte[64];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        [HttpPost]
        public bool PostValidateToken(string token, out string username)
        {
            username = null;

            var simplePrinciple = _tokenSupportService.GetPrincipal(token);
            var identity = simplePrinciple.Identity as ClaimsIdentity;

            if (identity == null)
                return false;

            if (!identity.IsAuthenticated)
                return false;

            var usernameClaim = identity.FindFirst(ClaimTypes.Name);
            username = usernameClaim?.Value;

            if (string.IsNullOrEmpty(username))
                return false;

            // More validate to check whether username exists in system

            return true;
        }
    }
}
