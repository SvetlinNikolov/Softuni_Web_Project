using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(SPN.Web.Areas.Identity.IdentityHostingStartup))]
namespace SPN.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}