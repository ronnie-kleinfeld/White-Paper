﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Http;
using TestProject5.Filters;

namespace TestProject5.Controllers {
    [RoutePrefix("values")]
    [RouteTimerFilter("ValuesController")]
    public class ValuesController : ApiController {
        // GET api/<controller>
        [HttpGet, Route("")]
        [ClientCacheControlFilter(ClientCacheControlEnum.Private, 10)]
        [RouteTimerFilter("GetAction")]
        public IEnumerable<string> Get() {
            Trace.WriteLine(DateTime.Now.ToLongTimeString() + "  Get called");
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet, Route("{id:int}")]
        public string Get(int id) {
            return "value";
        }

        // POST api/<controller>
        [HttpPost, Route("")]
        public void Post([FromBody] string value) {
        }

        // PUT api/<controller>/5
        [HttpPut, Route("{id:int}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<controller>/5
        [HttpDelete, Route("{id:int}")]
        public void Delete(int id) {
        }
    }
}