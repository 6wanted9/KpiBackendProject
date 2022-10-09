using KpiBackendProject.Interfaces;
using KpiBackendProject.Models;
using KpiBackendProject.Models.Entities;

namespace KpiBackendProject.Services
{
    internal class CategoryCreator : ICategoryCreator
    {
        private readonly IRepository<Category> _categoriesRepository;

        public CategoryCreator(IRepository<Category> categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        public Category Create(NamedModel category)
        {
            return _categoriesRepository.Add(new Category{ Name = category.Name });
        }
    }
}