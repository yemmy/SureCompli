using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SureCompli.Token;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.DependencyInjection;

namespace SureCompli.Controllers
{
    /* Inherit your controllers from this class.
     */

    [Route("api/[controller]/[action]")]
    public class AuthController : AbpController, ITransientDependency
    {
        private readonly IConfiguration _configuration;
        private readonly ISecureTokenService _tokenService;


        public AuthController(IConfiguration configuration, ISecureTokenService tokenService)
        {
            _configuration = configuration;
            _tokenService = tokenService;
        }

        [HttpPost]
        public ActionResult Token()
        {
            return Ok(_tokenService.PostToken());
        }
    
    }
}