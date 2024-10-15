using System.Collections.Generic;

namespace CDMD_Project.Repo
{
    public interface IProgressRepo
    {
        IEnumerable<HealthMetric> GetProgressByPatient(int patientId);
        void SaveNotes(int patientId, string notes);
    }
}
