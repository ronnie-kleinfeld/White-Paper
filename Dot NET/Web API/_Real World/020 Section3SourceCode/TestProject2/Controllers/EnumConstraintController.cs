using System.Web.Http;
using TestProject2.Enum;

namespace TestProject2.Controllers {
    public class EnumConstraintController : ApiController {
        // GET: EnumConstraint/gender/xxx
        [HttpGet, Route("gender/{gender:enum(TestProject2.Enum.GenderEnum)}")]
        public string GetGenderByEnum(GenderEnum gender) {
            return "Gender-" + gender.ToString();
        }
    }
}