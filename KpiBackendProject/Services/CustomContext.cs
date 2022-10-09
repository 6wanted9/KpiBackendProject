using System.Collections.Generic;
using System.Linq;
using KpiBackendProject.Interfaces;
using KpiBackendProject.Models.Entities;
using KpiBackendProject.Models.Entities.Abstract;

namespace KpiBackendProject.Services
{
    public class CustomContext : ICustomContext
    {
        private IEnumerable<User> Users { get; set; }

        private IEnumerable<Category> Categories { get; set; }

        private IEnumerable<Record> Records { get; set; }

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

        public void Remove<TEntity>(TEntity entity)
            where TEntity : Entity
        {
            switch (entity)
            {
                case User user:
                    Users = Users.Where(u => u.Id != user.Id);
                    break;
                case Category category:
                    Categories = Categories.Where(c => c.Id != category.Id);
                    break;
                case Record record:
                    Records = Records.Where(r => r.Id != record.Id);
                    break;
                default:
                    return;
            }
        }
    }
}