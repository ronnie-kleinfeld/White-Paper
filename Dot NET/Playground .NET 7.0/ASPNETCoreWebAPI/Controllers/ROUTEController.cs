using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreWebAPI.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ROUTEController : Controller {
        // /ROUTE/METHOD_ROUTE
        [HttpGet]
        [Route("METHOD_ROUTE")]
        public IEnumerable<int> METHOD() {
            return Enumerable.Range(1, 5);
        }
    }
}