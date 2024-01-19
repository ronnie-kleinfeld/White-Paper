using System;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace TestProject5.Filters {
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class ClientCacheActionFilterAttribute : ActionFilterAttribute {
        public ClientCacheEnum ClientCacheType;
        public double CacheSeconds;

        public ClientCacheActionFilterAttribute(double seconds = 60.0) {
            ClientCacheType = ClientCacheEnum.Private;
            CacheSeconds = seconds;
        }
        public ClientCacheActionFilterAttribute(ClientCacheEnum cacheType, double seconds = 60.0) {
            ClientCacheType = cacheType;
            CacheSeconds = seconds;
            if (cacheType == ClientCacheEnum.NoCache) {
                CacheSeconds = -1;
            }
        }

        public override async Task OnActionExecutedAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken) {
            // STEP 2: Call the rest of the action filter chain
            await base.OnActionExecutedAsync(actionExecutedContext, cancellationToken);

            // STEP 3: Any logic you want to do AFTER the other action filters, and AFTER the action method itself is called.
            if (actionExecutedContext.Response == null) {
                return;
            }

            if (ClientCacheType == ClientCacheEnum.NoCache) {
                actionExecutedContext.Response.Headers.CacheControl = new CacheControlHeaderValue {
                    NoStore = true
                };

                // for older browsers
                actionExecutedContext.Response.Headers.Pragma.TryParseAdd("no-cache");

                // create a date if none present, so we can have Expires match it
                if (!actionExecutedContext.Response.Headers.Date.HasValue) {
                    actionExecutedContext.Response.Headers.Date = DateTimeOffset.UtcNow;
                }
                if (actionExecutedContext.Response.Content != null) {
                    actionExecutedContext.Response.Content.Headers.Expires = actionExecutedContext.Response.Headers.Date;
                }
            } else {
                actionExecutedContext.Response.Headers.CacheControl = new CacheControlHeaderValue {
                    Public = (ClientCacheType == ClientCacheEnum.Public),
                    Private = (ClientCacheType == ClientCacheEnum.Private),
                    NoCache = false,
                    MaxAge = TimeSpan.FromSeconds(CacheSeconds)
                };
                // create a date if none present, so we can have Expires match it
                if (!actionExecutedContext.Response.Headers.Date.HasValue) {
                    actionExecutedContext.Response.Headers.Date = DateTimeOffset.UtcNow;
                }
                if (actionExecutedContext.Response.Content != null) {
                    actionExecutedContext.Response.Content.Headers.Expires =
                        actionExecutedContext.Response.Headers.Date;
                }
            }
        }
    }
}