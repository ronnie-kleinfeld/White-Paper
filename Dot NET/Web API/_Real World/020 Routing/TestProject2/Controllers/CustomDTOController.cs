using Routing.Models;
using System.Web.Http;

namespace Routing.Controllers {
    public class CustomDTOController : ApiController {
        [HttpGet, Route("")]
        public IHttpActionResult GetComplexDTO([FromUri] CustomDTO customDTO) {
            customDTO.String1 = "Ronnie Get";
            return Json(customDTO);
        }

        // POST: api/Values
        [HttpPost, Route("")]
        public IHttpActionResult Post([FromBody] CustomDTO customDTO) {
            customDTO.String1 = "Ronnie Post";
            return Json(customDTO);
        }
    }
}