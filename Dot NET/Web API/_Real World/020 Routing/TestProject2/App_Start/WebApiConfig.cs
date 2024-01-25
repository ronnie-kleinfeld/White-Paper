using System.Web.Http;
using System.Web.Http.Routing;
using Routing.Enum;
using Routing.Models;

namespace Routing {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Web API configuration and services

            // Web API routes
            //config.MapHttpAttributeRoutes();
            var constraintResolver = new DefaultInlineConstraintResolver();
            constraintResolver.ConstraintMap.Add("enum", typeof(EnumRouteConstraint));
            config.MapHttpAttributeRoutes(constraintResolver);

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}