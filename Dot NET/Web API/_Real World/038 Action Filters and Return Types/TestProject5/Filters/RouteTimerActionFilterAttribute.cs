using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace TestProject5.Filters {
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class RouteTimerActionFilterAttribute : ActionFilterAttribute {
        public const string Header = "X-ActionFilter-Timer";
        public const string TimerPropertyName = "RouteTimerFilter_";
        public string TimerName;

        public RouteTimerActionFilterAttribute(string name) {
            TimerName = name;
        }

        public override async Task OnActionExecutingAsync(HttpActionContext actionContext, CancellationToken cancellationToken) {
            // STEP 1:  Any logic you want to do BEFORE the rest of the action filter chain is called, and BEFORE the action method itself.
            actionContext.Request.Properties[TimerPropertyName + TimerName] = Stopwatch.StartNew();

            // STEP 2: Call the rest of the action filter chain
            await base.OnActionExecutingAsync(actionContext, cancellationToken);

            // STEP 3: Any logic you want to do AFTER the other action filters, but BEFORE the action method itself is called.
        }

        public override async Task OnActionExecutedAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken) {
            // STEP 1:  Any logic you want to do BEFORE the rest of the action filter chain is called, and AFTER the action method itself.
            var timer = (Stopwatch)actionExecutedContext.Request.Properties[TimerPropertyName + TimerName];
            var time = timer.ElapsedMilliseconds;

            Trace.Write(actionExecutedContext.Request.Method + " " + actionExecutedContext.Request.RequestUri + " " + actionExecutedContext.ActionContext.ActionDescriptor.ActionName + " - Elapsed time for " + TimerName + " was " + time + "\n");

            // STEP 2: Call the rest of the action filter chain
            await base.OnActionExecutedAsync(actionExecutedContext, cancellationToken);

            // STEP 3: Any logic you want to do AFTER the other action filters, and AFTER the action method itself is called.
            actionExecutedContext.Response.Headers.Add(Header, time + " msec");
        }
    }
}