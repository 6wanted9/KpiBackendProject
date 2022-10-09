using KpiBackendProject.Interfaces;
using KpiBackendProject.Models;
using KpiBackendProject.Models.Entities;

namespace KpiBackendProject.Services
{
    internal class UserCreator : IUserCreator
    {
        private readonly IRepository<User> _usersRepository;

        public UserCreator(IRepository<User> usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public User Create(NamedModel user)
        {
            return _usersRepository.Add(new User{ Name = user.Name });
        }
    }
}