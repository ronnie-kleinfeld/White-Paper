using System.Collections.Generic;
using System.Web.Http;

namespace Routing.Controllers {
    // annotate class for a controller prefix
    [RoutePrefix("routeprefix")]
    public class RoutePrefixController : ApiController {
        // GET: /routeprefix/
        [HttpGet, Route("")]
        public IEnumerable<string> Get1() {
            return new string[] { "value1", "value2" };
        }
        // GET: /routeprefix/verbprefix
        [HttpGet, Route("verbprefix")]
        public IEnumerable<string> Get2() {
            return new string[] { "value1", "value2" };
        }
        // GET: /ignorerouteprefix
        [HttpGet, Route("~/ignorerouteprefix")]
        public IEnumerable<string> Get3() {
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

        // annotate method with specific path
        // GET: /verbsprefix/DoSomething
        [HttpGet, Route("DoSomething")]
        public IEnumerable<string> GetSomething() {
            return new string[] { "value1", "value2" };
        }

        // annotate method with multiple paths
        // GET: /verbsprefix/MultipleRoute1 & /verbsprefix/MultipleRoute2
        [HttpGet]
        [Route("MultipleRoute1")]
        [Route("MultipleRoute2")]
        public IEnumerable<string> MultipleRoute() {
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

    [RoutePrefix("acceptvebs")]
    public class AcceptVerbsController : ApiController {
        // GET: /acceptvebs/verb
        [Route("verb")]
        [AcceptVerbs()] // defaults to POST verb
        public IEnumerable<string> Verb() {
            return new string[] { "value1", "value2" };
        }

        // GET|VIEW: /acceptvebs/multipleverbs
        [Route("multipleverbs")]
        [AcceptVerbs("GET", "VIEW", "PUT")] // view exists but is ignored by swagger
        public IEnumerable<string> MultipleVerbs() {
            return new string[] { "value1", "value2" };
        }
    }
}