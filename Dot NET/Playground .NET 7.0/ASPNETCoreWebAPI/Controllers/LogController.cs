using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreWebAPI.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class LogController : Controller {
        private readonly ILogger<LogController> _logger;

        public LogController(ILogger<LogController> logger) {
            _logger = logger;
        }

        [HttpGet(Name = "Log")]
        public IEnumerable<int> Get() {
            _logger.LogInformation("Ronnie Kleinfeld");

            return Enumerable.Range(1, 5);
        }
    }
}