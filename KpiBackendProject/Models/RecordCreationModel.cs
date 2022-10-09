using System;

namespace KpiBackendProject.Models
{
    public class RecordCreationModel
    {
        public Guid UserId { get; set; }

        public Guid CategoryId { get; set; }

        public decimal SpentAmount { get; set; }
    }
}