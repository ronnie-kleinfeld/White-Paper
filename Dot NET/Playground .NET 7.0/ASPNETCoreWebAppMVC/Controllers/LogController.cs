using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreWebAppMVC.Controllers {
    public class LogController : Controller {
        private readonly ILogger<LogController> _logger;

        public LogController(ILogger<LogController> logger) {
            _logger = logger;
        }

        public IActionResult LogInformation() {
            _logger.LogInformation("Ronnie Kleinfeld");

            return View();
        }
    }
}