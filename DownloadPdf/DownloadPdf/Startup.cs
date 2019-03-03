using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DownloadPdf.Startup))]
namespace DownloadPdf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
