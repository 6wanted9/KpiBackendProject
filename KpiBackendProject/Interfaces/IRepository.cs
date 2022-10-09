using System.Collections.Generic;
using KpiBackendProject.Models.Entities.Abstract;

namespace KpiBackendProject.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : Entity
    {
        TEntity Add(TEntity entity);

        IEnumerable<TEntity> GetAll();
    }
}