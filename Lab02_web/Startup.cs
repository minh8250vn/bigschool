using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab02_web.Startup))]
namespace Lab02_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
