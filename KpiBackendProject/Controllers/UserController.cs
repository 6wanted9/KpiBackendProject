using KpiBackendProject.Constants;
using KpiBackendProject.Interfaces;
using KpiBackendProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace KpiBackendProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserCreator _userCreator;

        public UserController(IUserCreator userCreator)
        {
            _userCreator = userCreator;
        }

        [HttpPost]
        [Route(Routes.User.Create)]
        public void Create([FromBody] NamedModel user)
        {
            _userCreator.Create(user);
        }
    }
}