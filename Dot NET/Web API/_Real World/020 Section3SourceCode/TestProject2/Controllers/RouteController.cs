using System.Collections.Generic;
using System.Web.Http;

namespace TestProject2.Controllers {
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
        [HttpGet, Route("add2integers")]
        public IEnumerable<string> Add(int i1, int i2) {
            return new string[] { "value1", "value2" };
        }
        [HttpGet, Route("add3integers")]
        public IEnumerable<string> Add(int i1, int i2, int i3) {
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

    [RoutePrefix("paramsprefix")]
    public class RouteParamsController : ApiController {
        // quesry string
        // GET: /paramsprefix/{id}
        [HttpGet, Route("{id}")]
        public IEnumerable<string> Get(int id) {
            return new string[] { id.ToString() };
        }
        // quesry string
        // GET: /paramsprefix/street/{street}/city/{city}/zip/{zip}
        [HttpGet, Route("street/{street}/city/{city}/zip/{zip}")]
        public IEnumerable<string> GetAddress(string street, string city, string zip) {
            return new string[] { street, city, zip };
        }

        // body
        // POST: /paramsprefix/
        [HttpPost, Route("")]
        public string Post([FromBody] string value) {
            return value;
        }
        // PUT: /paramsprefix/{id}
        [HttpPut, Route("{id}")]
        public IEnumerable<string> Put(int id, [FromBody] string value) {
            return new string[] { id.ToString(), value };
        }
    }
}