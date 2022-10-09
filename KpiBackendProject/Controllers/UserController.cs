using System.Collections.Generic;
using KpiBackendProject.Constants;
using KpiBackendProject.Interfaces;
using KpiBackendProject.Models;
using KpiBackendProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KpiBackendProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserCreator _userCreator;
        private readonly IRepository<User> _usersRepository;

        public UserController(
            IUserCreator userCreator,
            IRepository<User> usersRepository)
        {
            _userCreator = userCreator;
            _usersRepository = usersRepository;
        }

        [HttpPost]
        [Route(Routes.User.Create)]
        public void Create([FromBody] NamedModel user)
        {
            _userCreator.Create(user);
        }

        [HttpGet]
        [Route(Routes.User.GetAll)]
        public IEnumerable<User> GetAll()
        {
            return _usersRepository.GetAll();
        }
    }
}