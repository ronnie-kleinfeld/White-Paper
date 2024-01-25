using Routing.ModelBinder;
using System;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace Routing.Controllers {
    public class WildcardParamsController : ApiController {
        [HttpGet, Route("dates/{*myDate:datetime}")]
        public string GetDate(DateTime myDate) {
            return myDate.ToLongDateString();
        }

        // GET: /segments/test1/test2/test3/test4
        // the arr parameter will be an array of 4 items - test1, test2, test3, test4
        [HttpGet, Route("segments/{*array:maxlength(256)}")]
        public string[] GetSegments([ModelBinder(typeof(StringArrayWildcardBinder))] string[] arr) {
            return arr;
        }
    }
}