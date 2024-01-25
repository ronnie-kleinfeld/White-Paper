using System.Web.Http;
using TestProject6.AuthFilters;

namespace TestProject6 {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Add this to insure the IIS layer hasn't added some IPrincipal authentication
            config.SuppressHostPrincipal();

            // Web API configuration and services
            config.Filters.Add(new BasicAuthFilterAttribute());
            config.Filters.Add(new JWTAuthFilterAttribute());

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