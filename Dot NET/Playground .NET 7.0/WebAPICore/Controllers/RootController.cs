using Microsoft.AspNetCore.Mvc;

namespace WebAPICore.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class RootController : ControllerBase {
        [HttpGet(Name = nameof(GetRoot))]
        public IActionResult GetRoot() {
            var response = new {
                href = Url.Link(nameof(GetRoot), null),
                rooms = new {
                    href = Url.Link(nameof(RoomController.GetRooms), null)
                }
            };

            return Ok(response);
        }
    }
}