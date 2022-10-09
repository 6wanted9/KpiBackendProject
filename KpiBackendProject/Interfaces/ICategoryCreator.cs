using KpiBackendProject.Models;
using KpiBackendProject.Models.Entities;

namespace KpiBackendProject.Interfaces
{
    public interface ICategoryCreator
    {
        Category Create(NamedModel category);
    }
}