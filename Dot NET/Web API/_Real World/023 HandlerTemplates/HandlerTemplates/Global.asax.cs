using System;
using System.Web.Http;

namespace HandlerTemplates {
    public class WebApiApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        /// <summary>
        /// Gets called for unhandled exceptions outside of the web api pipeline.
        /// </summary>
        /// <remarks>
        /// The pipeline is not active so the Response is unavailable. Since this is a handler
        /// outside the pipeline, the circumstances are unusual enough that you should
        /// at least log the error to some place that will get noticed.
        /// </remarks>
        protected void Application_Error(object sender, EventArgs e) {
            var ex = Server.GetLastError();
            // TODO: log the error somewhere
            //Trace.WriteLine("*** Global.Asax ERROR: " + ex.ToString());
        }
    }
}