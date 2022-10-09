using System.Linq;
using KpiBackendProject.Interfaces;
using KpiBackendProject.Models;
using KpiBackendProject.Models.Entities;

namespace KpiBackendProject.Services
{
    internal class RecordCreationValidator : IRecordCreationValidator
    {
        private readonly IRepository<User> _usersRepository;
        private readonly IRepository<Category> _categoriesRepository;

        public RecordCreationValidator(
            IRepository<User> usersRepository,
            IRepository<Category> categoriesRepository)
        {
            _usersRepository = usersRepository;
            _categoriesRepository = categoriesRepository;
        }

        public bool IsValid(RecordCreationModel creationModel)
        {
            return _usersRepository.GetAll().Any(u => u.Id == creationModel.UserId) &&
                   _categoriesRepository.GetAll().Any(c => c.Id == creationModel.CategoryId);
        }
    }
}