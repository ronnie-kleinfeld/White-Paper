using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace TestProject8.Exceptions {
    // Global unhandled exception logging/analytics template
    public class GlobalExceptionLoggerTemplate : ExceptionLogger {
        // Required ExceptionLogger method to process an exception
        // Important! Not every ExceptionLoggerContext field will be set depending on where the exception occurs, but you can minimally count on the Exception and Request properties
        public override Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken) {
            // STEP 1: do whatever analytics you like on the exception
            var ex = context.Exception;

            // example - simple trace logging
            // Trace.WriteLine("*** Exception: " + ex.ToString());

            return Task.FromResult(0);
        }
    }
}