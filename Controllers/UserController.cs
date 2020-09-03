using Microsoft.AspNetCore.Mvc;

namespace Activity.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {
        public ActionResult AddUser() => Ok();
    }
}