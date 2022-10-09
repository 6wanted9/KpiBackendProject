using System;
using KpiBackendProject.Interfaces;
using KpiBackendProject.Models.Entities.Abstract;

namespace KpiBackendProject.Services
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        private readonly ICustomContext _context;

        public Repository(ICustomContext context)
        {
            _context = context;
        }

        public TEntity Add<TEntity>(TEntity entity)
            where TEntity : Entity
        {
            SetId(entity);
            _context.Add(entity);

            return entity;
        }

        public void Remove<TEntity>(TEntity entity)
            where TEntity : Entity
        {
            _context.Remove(entity);
        }

        public void RemoveById<TEntity>(Guid entityId)
            where TEntity : Entity, new()
        {
            _context.Remove(new TEntity{ Id = entityId });
        }

        private void SetId<TEntity>(TEntity entity)
            where TEntity : Entity
        {
            entity.Id = Guid.NewGuid();
        }
    }
}