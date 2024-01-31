using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNETWebApplicationMVC.Startup))]
namespace ASPNETWebApplicationMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
