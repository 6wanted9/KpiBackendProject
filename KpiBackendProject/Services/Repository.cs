using System;
using System.Collections.Generic;
using KpiBackendProject.Interfaces;
using KpiBackendProject.Models.Entities.Abstract;

namespace KpiBackendProject.Services
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : Entity, new()
    {
        private readonly ICustomContext _context;

        public Repository(ICustomContext context)
        {
            _context = context;
        }

        public TEntity Add(TEntity entity)
        {
            SetId(entity);
            _context.Add(entity);

            return entity;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.GetAll<TEntity>();
        }

        private void SetId(TEntity entity)
        {
            entity.Id = Guid.NewGuid();
        }
    }
}