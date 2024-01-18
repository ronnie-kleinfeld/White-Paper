using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebAPICore.Models;

namespace WebAPICore.Filters {
    public class JsonExceptionFilter : IExceptionFilter {
        private readonly IWebHostEnvironment webHostEnvironment;

        public JsonExceptionFilter(IWebHostEnvironment webHostEnvironment) {
            this.webHostEnvironment = webHostEnvironment;
        }

        public void OnException(ExceptionContext context) {
            var error = new ApiError();

            if (webHostEnvironment.IsDevelopment()) {
                error.Message = context.Exception.Message;
                error.Detail = context.Exception.StackTrace;
            } else {
                error.Message = "A server error occurred";
                error.Detail = context.Exception.Message;
            }

            context.Result = new ObjectResult(error) {
                StatusCode = 500
            };
        }
    }
}