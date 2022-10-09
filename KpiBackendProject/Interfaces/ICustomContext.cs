using KpiBackendProject.Models.Entities.Abstract;

namespace KpiBackendProject.Interfaces
{
    public interface ICustomContext
    {
        void Add<TEntity>(TEntity entity)
            where TEntity : Entity;

        void Remove<TEntity>(TEntity entity)
            where TEntity : Entity;
    }
}