using System.Collections.Generic;
using System.Web.Http;

namespace Routing.Controllers {
    // annotate class for a controller prefix
    [RoutePrefix("routeprefix")]
    public class RoutePrefixController : ApiController {
        // GET: /routeprefix/
        [HttpGet, Route("")]
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }
    }

    [RoutePrefix("verbsprefix")]
    public class RouteVerbsController : ApiController {
        // must annotate a method to make ApiController as WEB API
        // GET: /verbsprefix/
        [HttpGet, Route("")]
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // NO conflict because verb is diferrent
        // POST: /verbsprefix/
        [HttpPost, Route("")]
        public IEnumerable<string> Post() {
            return new string[] { "value1", "value2" };
        }

        // annotate method with spesific path
        // GET: /verbsprefix/DoSomething
        [HttpGet, Route("DoSomething")]
        public IEnumerable<string> GetSomething() {
            return new string[] { "value1", "value2" };
        }

        // overload
        [HttpGet, Route("add/{i1}/{i2}")]
        public IEnumerable<string> Add(int i1, int i2) {
            return new string[] { "value1", "value2" };
        }
        [HttpGet, Route("multiply/{i1}/{i2}")]
        public IEnumerable<string> Multiply(int i1, int i2) {
            return new string[] { "value1", "value2" };
        }
    }

    // BAD practice, this override other specific paths in same controller
    [RoutePrefix("badprefix")]
    public class RouteBADController : ApiController {
        // GET: /badprefix/{param1}
        [HttpGet, Route("{param1}")]
        public IEnumerable<string> Get(string param1) {
            return new string[] { param1 };
        }
    }
}