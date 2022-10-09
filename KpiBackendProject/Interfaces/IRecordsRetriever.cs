using System;
using System.Collections.Generic;
using KpiBackendProject.Models.Entities;

namespace KpiBackendProject.Interfaces
{
    public interface IRecordsRetriever
    {
        IEnumerable<Record> GetByUserAndCategoryIds(Guid userId, Guid categoryId);

        IEnumerable<Record> GetByUserId(Guid userId);
    }
}