using System;
using KpiBackendProject.Models.Entities.Abstract;

namespace KpiBackendProject.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : Entity
    {
        TEntity Add<TEntity>(TEntity entity)
            where TEntity : Entity;

        void Remove<TEntity>(TEntity entity)
            where TEntity : Entity;

        void RemoveById<TEntity>(Guid entityId)
            where TEntity : Entity, new();
    }
}