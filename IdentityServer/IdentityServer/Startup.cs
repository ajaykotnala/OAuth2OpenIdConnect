using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using IdentityServer.Config;
using IdentityServer3.Core.Configuration;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(IdentityServer.Startup))]

namespace IdentityServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            app.Map("/identity", idsrvApp =>
            {
                var idServerServiceFactory =
                    new IdentityServerServiceFactory().UseInMemoryClients(Clients.Get())
                        .UseInMemoryScopes(Scopes.Get())
                        .UseInMemoryUsers(Users.Get());

                var options = new IdentityServerOptions
                {
                    Factory = idServerServiceFactory,
                    SiteName = "Standalone Identity Server",
                    IssuerUri = "https://google.com",
                    PublicOrigin = "https://localhost:44300/",
                    SigningCertificate = LoadCertificate()
                };

                idsrvApp.UseIdentityServer(options);
            });

        }

        X509Certificate2 LoadCertificate()
        {
            // return new X509Certificate2(string.Format(@"{0}\Certificates\idsrv3test.pfx", AppDomain.CurrentDomain.BaseDirectory), "idsrv3test");
            return new X509Certificate2($@"{AppDomain.CurrentDomain.BaseDirectory}\Certificates\idsrv3test.pfx", "idsrv3test");
        }
    }
}
