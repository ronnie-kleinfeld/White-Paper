using System.Collections.Generic;
using System.Web.Http;
using TestProject6.AuthFilters;

namespace TestProject6.Controllers {
    [RoutePrefix("values")]
    public class ValuesController : ApiController {
        // GET api/<controller>
        [Route("authorize")]
        [Authorize]
        public IEnumerable<string> GetAuthorize() {
            return new string[] { User.Identity.Name, User.Identity.AuthenticationType };
        }

        // GET api/<controller>
        [Route("basicauth")]
        [BasicAuthFilter]
        public IEnumerable<string> GetBasicAuthFilter() {
            return new string[] { User.Identity.Name, User.Identity.AuthenticationType };
        }

        // GET api/<controller>
        [Route("requireclaim")]
        [RequireClaim("MyCustomClaim", IncludeMissingInResponse = true)]
        public IEnumerable<string> GetRequireClaim() {
            return new string[] { User.Identity.Name, User.Identity.AuthenticationType };
        }

        // GET api/<controller>/5
        public string Get(int id) {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value) {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<controller>/5
        public void Delete(int id) {
        }
    }
}