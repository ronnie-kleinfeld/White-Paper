using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNETWebApplicationWebForms.Startup))]
namespace ASPNETWebApplicationWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
