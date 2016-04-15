using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdentityServer3.Core.Models;

namespace IdentityServer.Config
{
    public static class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            return new List<Scope>
            {
                new Scope
                {
                    Name = "gallerymanagement",
                    DisplayName = "Galary Management",
                    Description = "Token has to contiain the scope to enable access to api's",
                    Type = ScopeType.Resource
                }
            };
        } 
    }
}