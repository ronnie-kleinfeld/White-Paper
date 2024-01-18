using Microsoft.AspNetCore.Mvc;

namespace WebAPICore.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase {
        [HttpGet(Name = nameof(GetRooms))]
        public IActionResult GetRooms() {
            throw new NotImplementedException();
        }
    }
}