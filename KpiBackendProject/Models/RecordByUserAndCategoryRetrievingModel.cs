using System;

namespace KpiBackendProject.Models
{
    public class RecordByUserAndCategoryRetrievingModel
    {
        public Guid UserId { get; set; }

        public Guid CategoryId { get; set; }
    }
}