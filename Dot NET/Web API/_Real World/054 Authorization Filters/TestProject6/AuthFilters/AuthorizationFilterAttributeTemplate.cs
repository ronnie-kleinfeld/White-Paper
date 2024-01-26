using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace TestProject6.AuthFilters {
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorizationFilterTemplateAttribute : AuthorizationFilterAttribute {
        // TODO: If you need constructor arguments, create properties to hold them and public constructors that accept them.
        public AuthorizationFilterTemplateAttribute() { }

        /// Called when authorization must be checked; 
        public override async Task OnAuthorizationAsync(HttpActionContext actionContext,
            CancellationToken cancellationToken) {
            // STEP 1: Perform your authorization logic
            // The authentication filters should have set an IPrincipal for you with various properties
            var principal = actionContext.RequestContext.Principal;

            //...though it is possible to have an authorization filter without or independent of authentication; perhaps based the presence of certain http headers in the request.  In that case use the appropriate logic. 

            // You can cast the IPrincipal to a specific class type to access the claims or properties of the authenticated principal:
            //var specificIdentityType = principal.Identity as ClaimsIdentity;
            //var claim = specificIdentityType.Claims.FirstOrDefault(a => a.Type.Equals("MyClaim"));

            var authorized = true; // DoSomeAuthorizationLogicMaybeEvenAsync();

            // STEP 2: If authorization fails, set the HTTP reponse and exit
            if (!authorized) {
                // return code - 403 Forbidden or 404 Not Found
                // https://stackoverflow.com/questions/3297048/403-forbidden-vs-401-unauthorized-http-responses
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Forbidden)
                ;//{ Content = ...};
                return;
            }

            await base.OnAuthorizationAsync(actionContext, cancellationToken);
        }
    }
}