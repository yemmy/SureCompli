using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text.Json;

namespace SureCompli.Token
{
    public interface ISecureTokenService
    {
        string PostAccessToken(Dictionary<string, string> input);
        string PostRefreshToken();
        //TokenResponse PostToken();
        JObject PostToken();
        bool PostValidateToken(string token, out string username);
    }
}