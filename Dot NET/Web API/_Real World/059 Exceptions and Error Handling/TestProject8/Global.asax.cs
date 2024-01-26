using System;
using System.Web.Http;

namespace TestProject8 {
    public class WebApiApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            GlobalConfiguration.Configuration.IncludeErrorDetailPolicy =
                IncludeErrorDetailPolicy.Default;

            GlobalConfiguration.Configure(WebApiConfig.Register);
            //throw new ArgumentNullException();
        }

        protected void Application_Error(object sender, EventArgs e) {
            Exception ex = Server.GetLastError();
            Context.Trace.Write("ERROR-- WebApiApplication.Application_OnError reached: " + ex.ToString());
        }
    }
}