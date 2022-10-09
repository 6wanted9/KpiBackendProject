using System;
using System.Data;
using KpiBackendProject.Interfaces;
using KpiBackendProject.Models;
using KpiBackendProject.Models.Entities;

namespace KpiBackendProject.Services
{
    internal class RecordCreator : IRecordCreator
    {
        private readonly IRepository<Record> _recordsRepository;
        private readonly IRecordCreationValidator _recordCreationValidator;

        public RecordCreator(
            IRepository<Record> recordsRepository,
            IRecordCreationValidator recordCreationValidator)
        {
            _recordsRepository = recordsRepository;
            _recordCreationValidator = recordCreationValidator;
        }

        public Record Create(RecordCreationModel creationModel)
        {
            if (!_recordCreationValidator.IsValid(creationModel))
            {
                throw new DBConcurrencyException(
                    $"Illegal attempt to create a Record with User Id '{creationModel.UserId}' and Category Id '{creationModel.CategoryId}'.");
            }

            var record = new Record
            {
                CategoryId = creationModel.CategoryId,
                UserId = creationModel.UserId,
                SpentAmount = creationModel.SpentAmount,
                CreationDate = DateTime.Now.ToUniversalTime(),
            };

            return _recordsRepository.Add(record);
        }
    }
}