using System.Collections.Generic;
using System.Linq;
using Activity.Data.Read;
using Activity.Models;
using Activity.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Activity.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IRepository<UsersModel> _users;

        public UserController(IRepository<UsersModel> users)
        {
            _users = users;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> getAllUsers()
        {
            return Ok(_users.getAll());
        }
    }
}