using System;
using KpiBackendProject.Models.Entities.Abstract;

namespace KpiBackendProject.Models.Entities
{
    public class Record : Entity
    {
        public Guid UserId { get; set; }

        public Guid CategoryId { get; set; }

        public DateTime CreationDate { get; set; }

        public decimal SpentAmount { get; set; }
    }
}