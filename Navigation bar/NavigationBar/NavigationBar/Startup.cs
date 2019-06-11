using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NavigationBar.Startup))]
namespace NavigationBar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
