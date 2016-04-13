using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdentityServer3.Core.Services.InMemory;

namespace IdentityServer.Config
{
    public static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>()
            {
                new InMemoryUser
                {
                    Subject = "1",
                    Username = "Ajay Kotnala",
                    Password = "Password123!"
                },
                 new InMemoryUser
                {
                    Subject = "1",
                    Username = "Deepika Padukone",
                    Password = "IWish!"
                }
            };
        }
    }
}