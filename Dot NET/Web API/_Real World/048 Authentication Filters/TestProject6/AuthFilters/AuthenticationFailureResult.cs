using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace TestProject6.AuthFilters {
    /// Generic authentication failure action result, for use in authentication filters
    public class AuthenticationFailureResult : IHttpActionResult {
        /// Optional override value for the ReasonPhrase on the final 401 Unauthorized response, i.e. replaces "Unauthorized".
        public string ReasonPhrase { get; private set; }

        /// HttpRequestMessage for this response
        public HttpRequestMessage Request { get; private set; }

        /// Constructor taking only the original HttpRequestMessage
        public AuthenticationFailureResult(HttpRequestMessage request) {
            ReasonPhrase = null;
            Request = request;
        }

        /// Constructor taking an override value for ReasonPhrase to use instead of "Unauthorized", plus the original HttpRequestMessage
        public AuthenticationFailureResult(string reasonPhrase, HttpRequestMessage request) {
            ReasonPhrase = reasonPhrase;
            Request = request;
        }

        /// IHttpActionResult implementation to retrieve the HttpResponseMessage result
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken) {
            return Task.FromResult(Execute());
        }

        /// Internal method to manually create a new HttpResponseMessage containing the 401 status code and the reason phrase.
        private HttpResponseMessage Execute() {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            response.RequestMessage = Request;

            if (!String.IsNullOrEmpty(ReasonPhrase)) {
                response.ReasonPhrase = ReasonPhrase;
            } else {
                response.ReasonPhrase = Enum.GetName(typeof(HttpStatusCode), HttpStatusCode.Unauthorized);
            }

            return response;
        }
    }
}