using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sso_demo.Startup))]
namespace sso_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
