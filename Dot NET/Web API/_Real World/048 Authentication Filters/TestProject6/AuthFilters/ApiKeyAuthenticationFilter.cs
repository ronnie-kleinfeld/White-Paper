﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace TestProject6.AuthFilters {
    public class ApiKeyAuthenticationFilterAttribute : Attribute, IAuthenticationFilter {
        // Set to the Authorization header Scheme value that this filter is intended to support
        public const string SupportedTokenScheme = "ApiKey";
        public const string ApiKeyHeader = "X-API-Key";

        // TODO: Decide if your filter should allow multiple instances per controller or per-method; set AllowMultiple to true if so
        public bool AllowMultiple { get { return false; } }

        // True if the filter supports WWW-Authenticate challenge headers, defaults to false.
        public bool SendChallenge { get; set; }

        /// Logic to authenticate the credentials. Must do one of:
        ///  -- exit out, doing nothing, if it cannot understand the token scheme presented, -- set context.ErrorResult to an IHttpActionResult holding reason for invalid authentication. -- set context.Principal to an IPrincipal if authenticated,
        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken) {
            string apiKey = null;

            // STEP 1: extract your credentials from the request.  Generally this should be the Authorization header, which the rest of this template assumes, but could come from any part of the request headers.

            // try the legacy header first
            if (context.Request.Headers.Contains(ApiKeyHeader)) {
                apiKey = context.Request.Headers.GetValues(ApiKeyHeader).FirstOrDefault();
            }

            if (String.IsNullOrEmpty(apiKey)) {
                var authHeader = context.Request.Headers.Authorization;
                // if there are no credentials, abort out
                if (authHeader == null) {
                    return;
                }

                // STEP 2: if the token scheme isn't understood by this authenticator, abort out
                var tokenType = authHeader.Scheme;
                if (!tokenType.Equals(SupportedTokenScheme)) {
                    return;
                }

                // STEP 3: Given a valid token scheme, verify credentials are present
                apiKey = authHeader.Parameter;
                if (String.IsNullOrEmpty(apiKey)) {
                    // no credentials sent with the scheme, abort out of the pipeline with an error result
                    context.ErrorResult = new AuthenticationFailureResult("Missing credentials", context.Request);
                    return;
                }
            }

            // STEP 4: validate the credentials.  Return an error if invalid, else set the IPrincipal 
            //         on the context.
            IPrincipal principal = await ValidateCredentialsAsync(apiKey, cancellationToken);
            if (principal == null) {
                context.ErrorResult = new AuthenticationFailureResult("Invalid credentials", context.Request);
            } else {
                // We have a valid, authenticated user; save off the IPrincipal instance
                context.Principal = principal;
            }
        }

        /// <summary>
        /// Extra logic associated with Basic/Digest authentication scheme, to 
        /// add the WWW-Authenticate header; for other token schemes, you can just do 
        /// nothing as shown below.
        /// </summary>
        /// <remarks>
        /// For Basic authentication, see the Microsoft sample.
        /// https://docs.microsoft.com/en-us/aspnet/web-api/overview/security/authentication-filters
        /// If you wanted to support WWW-Authenticate challenges for a non-basic token type,
        /// you can use the AddChallengeOnUnauthorizedResult line of code below.
        /// But note doing so is non necessarily required, in that WWW-Authenticate is 
        /// intended for users from browsers where the browser understands the token 
        /// scheme requested and can ask the user for credentials, it was not 
        /// meant for arbitrary custom tokens used by callers that are not browsers.
        /// </remarks>
        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken) {
            // if this filter wants to support WWW-Authenticate header challenges, add one to the
            // result
            if (SendChallenge) {
                context.Result = new AddChallengeOnUnauthorizedResult(
                    new AuthenticationHeaderValue(SupportedTokenScheme), context.Result);
            }

            return Task.FromResult(0);
        }

        /// <summary>
        /// Internal method to validate the credentials included in the request,
        /// returning an IPrincipal for the resulting authenticated entity.
        /// </summary>
        private async Task<IPrincipal> ValidateCredentialsAsync(string credentials, CancellationToken cancellationToken) {
            // validate the 8 char length requirement
            if (credentials.Length != 8) {
                return null;
            }

            IList<Claim> claimCollection = new List<Claim>
            {
                new Claim(ClaimTypes.Name, credentials),
                new Claim(ClaimTypes.AuthenticationInstant, DateTime.UtcNow.ToString("o")),
                new Claim("urn:ClientAccount", credentials.Substring(0,3))
            };

            var identity = new ClaimsIdentity(claimCollection, SupportedTokenScheme);
            var principal = new ClaimsPrincipal(identity);

            return await Task.FromResult(principal);
        }
    }
}