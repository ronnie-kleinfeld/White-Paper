using System.Collections.Generic;
using System.Web.Http;
using TestProject6.AuthFilters;

namespace TestProject6.Controllers {
    [RoutePrefix("authurization")]
    public class AuthorizationController : ApiController {
        // GET /authurization/None
        [HttpGet, Route("None")]
        public string GetNone() {
            return "value";
        }

        // GET /authurization/AllowAnonymous
        [HttpGet, Route("AllowAnonymous")]
        [AllowAnonymous] // override authentication and authorization in WebApiConfig.cs
        public string GetAllowAnonymous() {
            return "value";
        }

        // GET /authurization/Authorize
        [HttpGet, Route("Authorize")]
        [Authorize] // validate that there is an IPrincipal
        public string GetAuthorize() {
            return "value";
        }

        // GET /authurization/RolesUsers
        [HttpGet, Route("RolesUsers")]
        [Authorize(Roles = "Admin", Users = "userName")]
        public string GetRolesUsers() {
            return "value";
        }
    }
}