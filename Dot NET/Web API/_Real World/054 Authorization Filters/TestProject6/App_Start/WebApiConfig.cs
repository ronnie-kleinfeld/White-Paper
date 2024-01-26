using System.Web.Http;
using TestProject6.Handlers;

namespace TestProject6 {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            config.SuppressHostPrincipal();

            // Web API configuration and services
            config.MessageHandlers.Add(new ForwardedHeadersHandler());
            config.MessageHandlers.Add(new ApiKeyHeaderHandler());

            // add this to require all controller to be authorized
            //config.Filters.Add(new AuthorizeAttribute());

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}