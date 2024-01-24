using System.Web.Http;
using Routing.Enum;

namespace Routing.Controllers {
    public class EnumConstraintController : ApiController {
        // GET: EnumConstraint/gender/xxx
        [HttpGet, Route("gender/{gender:enum(Routing.Enum.GenderEnum)}")]
        public string GetGenderByEnum(GenderEnum gender) {
            return "Gender-" + gender.ToString();
        }
    }
}