﻿namespace TestProject5.Filters {
    /// https://developers.google.com/web/fundamentals/performance/optimizing-content-efficiency/http-caching
    /// </remarks>
    public enum ClientCacheEnum {
        Public,     // proxy cache
        Private,    // browser-only
        NoCache     // no caching
    };
}