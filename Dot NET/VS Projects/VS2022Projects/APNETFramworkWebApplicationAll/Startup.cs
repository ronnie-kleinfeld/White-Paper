using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APNETFramworkWebApplicationAll.Startup))]
namespace APNETFramworkWebApplicationAll
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
