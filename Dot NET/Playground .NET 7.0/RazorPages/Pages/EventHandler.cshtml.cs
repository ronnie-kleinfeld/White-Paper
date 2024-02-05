using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages {
    public class EventHandlerModel : PageModel {
        [BindProperty]
        public string Title { get; set; }

        public void OnGetDoEventHandler() {
            Title = "New Title";
        }
    }
}