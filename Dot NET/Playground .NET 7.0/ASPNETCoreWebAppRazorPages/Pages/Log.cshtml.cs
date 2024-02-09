using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreWebAppRazorPages.Pages {
    public class LogModel : PageModel {
        private readonly ILogger<LogModel> _logger;

        public LogModel(ILogger<LogModel> logger) {
            _logger = logger;
        }

        public void OnGet() {
            _logger.LogInformation("Ronnie Kleinfeld");
        }
    }
}