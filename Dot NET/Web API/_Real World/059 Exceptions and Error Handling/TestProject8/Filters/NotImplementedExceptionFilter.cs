using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace TestProject8.Filters {
    public class NotImplementedExceptionFilter : ExceptionFilterAttribute {
        /// Web API exception filter template. Generally meant for action- or controller-specific exceptions where you want common processing to occur.
        public override async Task OnExceptionAsync(
            HttpActionExecutedContext actionExecutedContext,
            CancellationToken cancellationToken) {
            // STEP 1
            // Do internal processing 
            var ex = actionExecutedContext.Exception;

            // ...AND/OR...

            // STEP 2:
            if (ex is NotImplementedException) {
                actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.NotImplemented);
            }

            await Task.FromResult(0);
        }
    }
}