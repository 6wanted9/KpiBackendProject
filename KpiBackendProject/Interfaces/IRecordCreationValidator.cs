using KpiBackendProject.Models;

namespace KpiBackendProject.Interfaces
{
    public interface IRecordCreationValidator
    {
        bool IsValid(RecordCreationModel creationModel);
    }
}