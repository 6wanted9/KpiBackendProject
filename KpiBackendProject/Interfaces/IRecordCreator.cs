using KpiBackendProject.Models;
using KpiBackendProject.Models.Entities;

namespace KpiBackendProject.Interfaces
{
    public interface IRecordCreator
    {
        Record Create(RecordCreationModel creationModel);
    }
}