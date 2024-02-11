using System.ComponentModel.DataAnnotations;

namespace ASPNETCoreWebAppRazorPageEF.Data.Model {
    public class Movie {
        public int Id { get; set; }
        [MinLength(5, ErrorMessage = "Min 5 letters")]
        public string Title { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }
    }
}