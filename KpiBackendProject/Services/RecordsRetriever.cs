using System;
using System.Collections.Generic;
using System.Linq;
using KpiBackendProject.Interfaces;
using KpiBackendProject.Models.Entities;

namespace KpiBackendProject.Services
{
    internal class RecordsRetriever : IRecordsRetriever
    {
        private readonly IRepository<Record> _recordsRepository;

        public RecordsRetriever(IRepository<Record> recordsRepository)
        {
            _recordsRepository = recordsRepository;
        }

        public IEnumerable<Record> GetByUserAndCategoryIds(Guid userId, Guid categoryId)
        {
            return GetByUserId(userId).Where(r => r.CategoryId == categoryId);
        }

        public IEnumerable<Record> GetByUserId(Guid userId)
        {
            return _recordsRepository.GetAll().Where(r => r.UserId == userId);
        }
    }
}