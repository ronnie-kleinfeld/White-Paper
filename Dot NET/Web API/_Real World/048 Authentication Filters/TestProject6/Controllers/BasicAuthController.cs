using System.Collections.Generic;
using System.Web.Http;
using TestProject6.AuthFilters;

namespace TestProject6.Controllers {
    [RoutePrefix("authentication")]
    public class BasicAuthController : ApiController {
        // this get the authentication from WebApiConfig.cs
        // GET /authentication
        [Route("")]
        public IEnumerable<string> Get() {
            return new string[] { User.Identity.Name, User.Identity.AuthenticationType };
        }

        // GET /authentication/allowanonymous
        [Route("allowanonymous")]
        [AllowAnonymous]
        public IEnumerable<string> GetAllowAnonymous() {
            return new string[] { User.Identity.Name, User.Identity.AuthenticationType };
        }

        // GET /authentication/authorize
        [Route("authorize")]
        [Authorize]
        public IEnumerable<string> GetAuthorize() {
            return new string[] { User.Identity.Name, User.Identity.AuthenticationType };
        }

        // GET /authentication/basicauth
        [Route("basicauth")]
        [BasicAuthFilter]
        public IEnumerable<string> GetBasicAuthFilter() {
            return new string[] { User.Identity.Name, User.Identity.AuthenticationType };
        }

        // GET /authentication/requireclaim
        [Route("requireclaim")]
        [RequireClaim("MyCustomClaim", IncludeMissingInResponse = true)]
        public IEnumerable<string> GetRequireClaim() {
            return new string[] { User.Identity.Name, User.Identity.AuthenticationType };
        }
    }
}