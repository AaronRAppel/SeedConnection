using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeedConnection.Web.Startup))]
namespace SeedConnection.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
