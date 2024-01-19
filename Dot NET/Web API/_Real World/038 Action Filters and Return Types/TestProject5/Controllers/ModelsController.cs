using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Web.Http;
using TestProject5.Filters;
using TestProject5.Models;

namespace TestProject5.Controllers {
    [RoutePrefix("models")]
    [ModelValidationActionFilter(false)]
    public class ModelsController : ApiController {
        [HttpPost, Route("validate_model_to_data_annotations")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(string))]
        public IHttpActionResult Post1([FromBody] ComplexTypeDto dto) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            return Ok("Posted data valid");
        }

        [HttpPost, Route("validate_model_to_action_filter")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(string))]
        [ModelValidationActionFilter(true)]
        public IHttpActionResult Post2([FromBody] ComplexTypeDto dto) {
            return Ok("Posted data valid");
        }
    }
}