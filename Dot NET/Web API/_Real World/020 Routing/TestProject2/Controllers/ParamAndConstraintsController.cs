using System.Collections.Generic;
using System.Web.Http;

namespace Routing.Controllers {
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

        // optional
        // GET: /paramsprefix/optional/{street}
        [HttpGet, Route("optional/{street?}")]
        public IEnumerable<string> Optional(string street = "My Street") {
            return new string[] { street };
        }

        // default
        // zip defaults to NULL
        // GET: /paramsprefix/default/{street}/{number}/{zip}
        [HttpGet, Route("default/{street=st}/{number:int}/{zip=}")]
        public IEnumerable<string> DefaultValue(string street, int number, string zip) {
            return new string[] { street, number.ToString(), zip };
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

    /// <summary>
    /// https://learn.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2#route-constraints
    /// </summary>
    [RoutePrefix("paramconstraints")]
    public class ParamConstraintsController : ApiController {
        // accept only integer, if string it will return 404 as not found
        // GET: /paramconstraints/{id}
        [HttpGet, Route("{id:int}")]
        public IEnumerable<string> Get(int id) {
            return new string[] { id.ToString() };
        }

        // integer range
        // GET: /paramconstraints/GetHighNumber/{id}
        [HttpGet, Route("GetHighNumber/{id:int:range(1000, 3000)}")]
        public IEnumerable<string> GetHighNumber(int id) {
            return new string[] { id.ToString() };
        }
    }
}