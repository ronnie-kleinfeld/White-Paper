using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace TestProject8.Exceptions {
    // Global exception handler template
    // Note you could daisy-chain several handlers together using the "inner handler" model if you need more than the one Web Api allows you to register. Just add a constructor taking the inner handler, and a property to hold it.
    public class GlobalExceptionHandlerTemplate : ExceptionHandler {
        // Required ExceptionHandler method to process an exception
        // Important! Not every ExceptionHandlerContext field will be set depending on where the exception occurs, but you can minimally count on the Exception and Request properties.
        public override Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken) {
            // STEP 1: exit if we cannot handle the exception (boilerplate code)

            // nothing we can do if the context is not present
            if (context == null) {
                throw new ArgumentNullException("context");
            }

            // verify this exception should be handled at all; exit if not
            if (!ShouldHandle(context)) {
                return Task.FromResult(0);
            }

            // STEP 2: Create an IHttpActionResult from the exception as required
            var ex = context.Exception;

            // in this example, we simply strip off the stack trace and leave only the error message
            //var responseMsg = context.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            //context.Result = new ResponseMessageResult(responseMsg);

            return Task.FromResult(0);
        }
    }
}