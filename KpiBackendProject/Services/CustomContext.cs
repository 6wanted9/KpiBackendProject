using System;
using System.Collections.Generic;
using System.Linq;
using KpiBackendProject.Interfaces;
using KpiBackendProject.Models.Entities;
using KpiBackendProject.Models.Entities.Abstract;

namespace KpiBackendProject.Services
{
    public class CustomContext : ICustomContext
    {
        private IEnumerable<User> Users { get; set; } = Enumerable.Empty<User>();

        private IEnumerable<Category> Categories { get; set; } = Enumerable.Empty<Category>();

        private IEnumerable<Record> Records { get; set; } = Enumerable.Empty<Record>();

        public void Add<TEntity>(TEntity entity)
            where TEntity : Entity
        {
            switch (entity)
            {
                case User user:
                    Users = Users.Append(user);
                    break;
                case Category category:
                    Categories = Categories.Append(category);
                    break;
                case Record record:
                    Records = Records.Append(record);
                    break;
                default:
                    return;
            }
        }

        public IEnumerable<TEntity> GetAll<TEntity>()
            where TEntity : Entity
        {
            return typeof(TEntity) switch
            {
                Type type when type == typeof(User) => Users as IEnumerable<TEntity>,
                Type type when type == typeof(Category) => Categories as IEnumerable<TEntity>,
                Type type when type == typeof(Record) => Records as IEnumerable<TEntity>,
            };
        }
    }
}