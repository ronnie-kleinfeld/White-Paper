using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNETWebApplicationAll.Startup))]
namespace ASPNETWebApplicationAll
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
