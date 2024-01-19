using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject4.Handlers {
    public class ApiKeyHeaderHandler : DelegatingHandler {
        public const string _apiKeyHeader = "X-API-Key";
        public const string _apiQueryString = "api_key"; // for swagger

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken) {
            // STEP 1: Global message-level logic that must be executed BEFORE the request is sent on to the action method
            string apikey = null;

            if (request.Headers.Contains(_apiKeyHeader)) {
                apikey = request.Headers.GetValues(_apiKeyHeader).FirstOrDefault();
            } else {
                var queryString = request.GetQueryNameValuePairs();
                var kvp = queryString.FirstOrDefault(a => a.Key.ToLowerInvariant().Equals(_apiQueryString));
                if (!string.IsNullOrEmpty(kvp.Value))
                    apikey = kvp.Value;
            }

            // save the value to Properties; 
            request.Properties.Add(_apiKeyHeader, apikey);

            // compress steps 2, 3 and 4 into one line since we don't need any post-request processing
            return base.SendAsync(request, cancellationToken);
        }
    }

    /// <summary>
    /// http request extension for retrieving key-value pair from request
    /// sample:
    /// request.GetApiKey("key")
    /// </summary>
    public static class HttpRequestMessageApiKeyExtension {
        public static object GetValue(this HttpRequestMessage request, string key) {
            if (request == null)
                return null;

            if (request.Properties.TryGetValue(key, out object value)) {
                return value;
            }

            return null;
        }
    }
}