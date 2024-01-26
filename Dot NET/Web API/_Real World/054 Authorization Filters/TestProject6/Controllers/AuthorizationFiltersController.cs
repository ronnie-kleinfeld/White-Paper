using System.Web.Http;
using TestProject6.AuthFilters;

namespace TestProject6.Controllers {
    [RoutePrefix("AuthorizationFilters")]
    public class AuthorizationFiltersController : ApiController {
        // GET /AuthorizationFilters/None
        [HttpGet, Route("None")]
        public string GetNone() {
            return "value";
        }

        // GET /AuthorizationFilters/RequireHttps
        [HttpGet, Route("RequireHttps")]
        [RequireHttpsAuthorizationFilterAttribute]
        public string GetRequireHttps() {
            return "value";
        }

        // GET /AuthorizationFilters/RequireApiKey
        [HttpGet, Route("RequireApiKey")]
        [RequireApiKeyAuthorizationFilter]
        public string GetRequireApiKey() {
            return "value";
        }
    }
}