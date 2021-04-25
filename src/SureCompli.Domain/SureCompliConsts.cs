using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SureCompli
{
    public static class SureCompliConsts
    {
        public const string DbTablePrefix = "App";

        public const string DbSchema = null;

        public static RSAParameters RSAParameters
        {
            get => new RSAParameters()
            {
                Modulus = Convert.FromBase64String("z7eXmrs9z3Xm7VXwYIdziDYzXGfi3XQiozIRa58m3ApeLVDcsDeq6Iv8C5zJ2DHydDyc0x6o5dtTRIb23r5/ZRj4I/UwbgrwMk5iHA0bVsXVPBDSWsrVcPDGafr6YbUNQnNWIF8xOqgpeTwxrqGiCJMUjuKyUx01PBzpBxjpnQ++Ryz6Y7MLqKHxBkDiOw5wk9cxO8/IMspSNJJosOtRXFTR74+bj+pvNBa8IJ+5Jf/UfJEEjk+qC+pohCAryRk0ziXcPdxXEv5KGT4zf3LdtHy1YwsaGLnTb62vgbdqqCJaVyHWOoXsDTQBLjxNl9o9CzP6CrfBGK6JV8pA/xfQlw=="),
                Exponent = Convert.FromBase64String("AQAB"),
                P = Convert.FromBase64String("+VsETS2exORYlg2CxaRMzyG60dTfHSuv0CsfmO3PFv8mcYxglGa6bUV5VGtB6Pd1HdtV/iau1WR/hYXQphCP99Pu803NZvFvVi34alTFbh0LMfZ+2iQ9toGzVfO8Qdbj7go4TWoHNzCpG4UCx/9wicVIWJsNzkppSEcXYigADMM="),
                Q = Convert.FromBase64String("1UCJ2WAHasiCdwJtV2Ep0VCK3Z4rVFLWg3q1v5OoOU1CkX5/QAcrr6bX6zOdHR1bDCPsH1n1E9cCMvwakgi9M4Ch0dYF5CxDKtlx+IGsZJL0gB6HhcEsHat+yXUtOAlS4YB82G1hZqiDw+Q0O8LGyu/gLDPB+bn0HmbkUC2kP50="),
                DP = Convert.FromBase64String("CBqvLxr2eAu73VSfFXFblbfQ7JTwk3AiDK/6HOxNuL+eLj6TvP8BvB9v7BB4WewBAHFqgBIdyI21n09UErGjHDjlIT88F8ZtCe4AjuQmboe/H2aVhN18q/vXKkn7qmAjlE78uXdiuKZ6OIzAJGPm8nNZAJg5gKTmexTka6pFJiU="),
                DQ = Convert.FromBase64String("ND6zhwX3yzmEfROjJh0v2ZAZ9WGiy+3fkCaoEF9kf2VmQa70DgOzuDzv+TeT7mYawEasuqGXYVzztPn+qHhrogqJmpcMqnINopnTSka6rYkzTZAtM5+35yz0yvZiNbBTFdwcuglSK4xte7iU828stNs/2JR1mXDtVeVvWhVUgCE="),
                InverseQ = Convert.FromBase64String("Heo0BHv685rvWreFcI5MXSy3AN0Zs0YbwAYtZZd1K/OzFdYVdOnqw+Dg3wGU9yFD7h4icJFwZUBGOZ0ww/gZX/5ZgJK35/YY/DeV+qfZmywKauUzC6+DPsrDdW1uf1eAety6/huRZTduBFTwIOlPdZ+PY49j6S38DjPFNImn0cU="),
                D = Convert.FromBase64String("IvjMI5cGzxkQqkDf2cC0aOiHOTWccqCM/GD/odkH1+A+/u4wWdLliYWYB/R731R5d6yE0t7EnP6SRGVcxx/XnxPXI2ayorRgwHeF+ScTxUZFonlKkVK5IOzI2ysQYMb01o1IoOamCTQq12iVDMvV1g+9VFlCoM+4GMjdSv6cxn6ELabuD4nWt8tCskPjECThO+WdrknbUTppb2rRgMvNKfsPuF0H7+g+WisbzVS+UVRvJe3U5O5X5j7Z82Uq6hw2NCwv2YhQZRo/XisFZI7yZe0OU2JkXyNG3NCk8CgsM9yqX8Sk5esXMZdJzjwXtEpbR7FiKZXiz9LhPSmzxz/VsQ==")
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1", "My API")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
              {
                new Client
                {
                    ClientId = "client",

                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    // secret for authentication
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                    // scopes that client has access to
                    AllowedScopes = { "api1" }
                }
            };
        }
    }
}
