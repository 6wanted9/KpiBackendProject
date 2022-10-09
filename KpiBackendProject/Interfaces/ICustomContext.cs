using System.Collections.Generic;
using KpiBackendProject.Models.Entities.Abstract;

namespace KpiBackendProject.Interfaces
{
    public interface ICustomContext
    {
        void Add<TEntity>(TEntity entity)
            where TEntity : Entity;

        IEnumerable<TEntity> GetAll<TEntity>()
            where TEntity : Entity;
    }
}