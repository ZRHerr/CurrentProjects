using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyApp.WebUI.Startup))]
namespace MyApp.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
