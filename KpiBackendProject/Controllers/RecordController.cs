using System.Collections.Generic;
using KpiBackendProject.Constants;
using KpiBackendProject.Interfaces;
using KpiBackendProject.Models;
using KpiBackendProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KpiBackendProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecordController : ControllerBase
    {
        private readonly IRecordCreator _recordCreator;
        private readonly IRecordsRetriever _recordsRetriever;

        public RecordController(
            IRecordCreator recordCreator,
            IRecordsRetriever recordsRetriever)
        {
            _recordCreator = recordCreator;
            _recordsRetriever = recordsRetriever;
        }

        [HttpPost]
        [Route(Routes.Record.Create)]
        public void Create([FromBody] RecordCreationModel creationModel)
        {
            _recordCreator.Create(creationModel);
        }

        [HttpGet]
        [Route(Routes.Record.GetByUser)]
        public IEnumerable<Record> GetByUser([FromQuery] RecordByUserRetrievingModel retrievingModel)
        {
            return _recordsRetriever.GetByUserId(retrievingModel.UserId);
        }

        [HttpGet]
        [Route(Routes.Record.GetByUserAndCategory)]
        public IEnumerable<Record> GetByUser([FromQuery] RecordByUserAndCategoryRetrievingModel retrievingModel)
        {
            return _recordsRetriever.GetByUserAndCategoryIds(retrievingModel.UserId, retrievingModel.CategoryId);
        }
    }
}