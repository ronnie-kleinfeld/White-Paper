using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Routing.Models;

namespace Routing.Controllers.OLD {
    public class ValuesController : ApiController {
        // GET: api/Values
        [HttpGet, Route("values")]
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Values/5
        public string Get(int id) {
            return "value";
        }

        // POST: api/Values
        public void Post([FromBody] string value) {
        }

        // PUT: api/Values/5
        public void Put([FromUri] int id, [FromBody] string value) {
        }

        // DELETE: api/Values/5
        public void Delete(int id) {
        }

        [HttpGet, Route("complex")]
        public IHttpActionResult ComplexTest([FromUri] CustomDTO obj) {
            return Json(obj);
        }

        [HttpPut, Route("bodytest")]
        public string BodyTest([FromBody] string value) {
            return value;
        }

        [HttpGet, Route("dates/{*myDate:datetime}")]
        public string GetDate(DateTime myDate) {
            return myDate.ToLongDateString();
        }

        [HttpGet, Route("segments/{*array:maxlength(256)}")]
        public string[] GetSegments([ModelBinder(typeof(StringArrayWildcardBinder))] string[] array) {
            return array;
        }
    }
}
