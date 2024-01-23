using System.Web.Http;

namespace TestProject2 {
    public class WebApiApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}