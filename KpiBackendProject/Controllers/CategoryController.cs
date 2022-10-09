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
    public class CategoryController : ControllerBase
    {
        private readonly IRepository<Category> _categoriesRepository;
        private readonly ICategoryCreator _categoryCreator;

        public CategoryController(
            IRepository<Category> categoriesRepository,
            ICategoryCreator categoryCreator)
        {
            _categoriesRepository = categoriesRepository;
            _categoryCreator = categoryCreator;
        }

        [HttpPost]
        [Route(Routes.Category.Create)]
        public void Create([FromBody] NamedModel category)
        {
            _categoryCreator.Create(category);
        }

        [HttpGet]
        [Route(Routes.Category.GetAll)]
        public IEnumerable<Category> GetAll()
        {
            return _categoriesRepository.GetAll();
        }
    }
}