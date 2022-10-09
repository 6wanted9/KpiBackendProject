using KpiBackendProject.Models;
using KpiBackendProject.Models.Entities;

namespace KpiBackendProject.Interfaces
{
    public interface IUserCreator
    {
        User Create(NamedModel user);
    }
}