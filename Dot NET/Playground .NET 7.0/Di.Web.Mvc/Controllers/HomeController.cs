using Microsoft.AspNetCore.Mvc;

namespace Di.Web.Mvc.Controllers {
    public class HomeController : BaseController {
        public HomeController() {
        }

        public IActionResult Index() {
            return View();
        }
    }
}