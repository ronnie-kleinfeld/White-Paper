using Swashbuckle.Swagger.Annotations;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TestProject5.ActionResults;
using TestProject5.Filters;
using TestProject5.Models;

namespace TestProject5.Controllers {
    [RoutePrefix("returntypes")]
    [ClientCacheActionFilter(ClientCacheEnum.NoCache)]
    public class ReturnTypesController : ApiController {
        // void converted to a 204 No Content
        [HttpGet, Route("void")]
        public void ReturnVoid() {
        }

        [HttpGet, Route("object")]
        public ComplexTypeDto GetObject() {
            var dto = new ComplexTypeDto() {
                String1 = "This is string 1",
                String2 = "This is string 2",
                Int1 = 55,
                Date1 = DateTime.Now
            };

            return dto;
        }

        [HttpGet, Route("exception")]
        public int GetException() {
            throw new InvalidOperationException("Error");
        }

        [HttpGet, Route("httpresponse")]
        [ResponseType(typeof(ComplexTypeDto))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ComplexTypeDto))]
        [SwaggerResponse(HttpStatusCode.BadRequest, Type = typeof(HttpError))]
        public HttpResponseMessage GetAnHttpResponse() {
            var dto = new ComplexTypeDto() {
                String1 = "This is string 1",
                String2 = "This is string 2",
                Int1 = 55,
                Date1 = DateTime.Now
            };

            // auto cast to JSON by content negotioator
            var response = Request.CreateResponse(dto);

            // not auto cast to JSON
            //var response = new HttpResponseMessage(HttpStatusCode.OK);
            //response.Content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");

            response.Headers.Add("X-MyCustomHeader", "MyHeaderValue");
            response.ReasonPhrase = "Most Excellent!";

            return response;
        }
        [HttpGet, Route("httpresponse_error")]
        [ResponseType(typeof(ComplexTypeDto))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ComplexTypeDto))]
        [SwaggerResponse(HttpStatusCode.BadRequest, Type = typeof(HttpError))]
        public HttpResponseMessage GetAnHttpResponseError() {
            var response = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid something or other");

            return response;
        }

        [HttpGet, Route("actionresult")]
        [ResponseType(typeof(ComplexTypeDto))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ComplexTypeDto))]
        public IHttpActionResult GetAnActionResult() {
            var dto = new ComplexTypeDto() {
                String1 = "This is string 1",
                String2 = "This is string 2",
                Int1 = 55,
                Date1 = DateTime.Now
            };

            // not auto cast to JSON
            //var response = Json(dto);

            // same as returning ComplexTypeDto type
            //var response = Ok(dto);

            // same as returning ComplexTypeDto type but can customize the response
            var response = Ok(dto).AddHeader("X-MyCustomHeader", "test value");

            return response;
        }
        [HttpGet, Route("actionresult_badrequest")]
        [ResponseType(typeof(ComplexTypeDto))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ComplexTypeDto))]
        public IHttpActionResult GetAnActionResultBadRequest() {
            // returns a http response kind and can customize the response
            var response = BadRequest("test test test").AddHeader("X-MyCustomHeader", "test value");

            return response;
        }
    }
}