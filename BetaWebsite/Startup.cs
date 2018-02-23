using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BetaWebsite.Startup))]
namespace BetaWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
