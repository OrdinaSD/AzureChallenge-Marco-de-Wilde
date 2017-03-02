using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarcoDeWildeSocialNetwork.Web.Startup))]
namespace MarcoDeWildeSocialNetwork.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
