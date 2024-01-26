using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace TestProject8.Filters {
    public class InvalidAccountIdExceptionFilter : ExceptionFilterAttribute {
        public override async Task OnExceptionAsync(
            HttpActionExecutedContext actionExecutedContext,
            CancellationToken cancellationToken) {
            // STEP 1:
            // Do internal processing 
            var ex = actionExecutedContext.Exception;

            // ...AND/OR...

            // STEP 2:
            if (ex is ArgumentOutOfRangeException) {
                actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.BadRequest) {
                    ReasonPhrase = "InvalidAccountId",
                    Content = new StringContent("Account Ids must be in the range 1 to 50")
                };
            }

            await Task.FromResult(0);
        }
    }
}