using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniHub.Startup))]
namespace UniHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
