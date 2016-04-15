using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdentityServer3.Core;
using IdentityServer3.Core.Models;

namespace IdentityServer.Config
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            //return new List<Client>();
            return new []
            {
                new Client
                {
                    ClientId = "tripgalleryclientcredentials",
                    ClientName = "Trip galary (client credentials)",
                    Flow = Flows.ClientCredentials,
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret(Application.Constants.Constants.ClientSecret.Sha256())
                    },
                    AllowAccessToAllScopes = true,
                    //AllowedScopes = new List<string>
                    //{
                    //    "galarymanagement"
                    //}
                }
            };
        }
    }
}