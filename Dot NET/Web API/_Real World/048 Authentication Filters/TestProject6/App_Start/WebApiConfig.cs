using System.Web.Http;
using TestProject6.AuthFilters;
using TestProject6.Handlers;

namespace TestProject6 {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Add this to insure the IIS layer hasn't added some IPrincipal authentication
            config.SuppressHostPrincipal();

            // Web API configuration and services
            config.MessageHandlers.Add(new ForwardedHeadersHandler());
            config.MessageHandlers.Add(new ApiKeyHeaderHandler());

            config.Filters.Add(new BasicAuthFilterAttribute());
            config.Filters.Add(new JwtAuthenticationFilterAttribute());

            config.Filters.Add(new AuthorizeAttribute());

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