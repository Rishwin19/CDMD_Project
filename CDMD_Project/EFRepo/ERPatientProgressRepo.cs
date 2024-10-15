using CDMD_Project.Repo;
using System.Collections.Generic;
using System.Linq;

namespace CDMD_Project.ERRepo
{
    public class ERPatientProgressRepo : IProgressRepo
    {
        private readonly CDMDContext _context;

        public ERPatientProgressRepo(CDMDContext context)
        {
            _context = context;
        }

        // Fetches health metrics for a specific patient
        public IEnumerable<HealthMetric> GetProgressByPatient(int patientId)
        {
            return _context.HealthMetrics
                           .Where(hm => hm.PatientID == patientId)
                           .OrderBy(hm => hm.MetricDate)
                           .ToList();
        }

        // Saves notes for a specific patient
        public void SaveNotes(int patientId, string notes)
        {
            var patient = _context.Patients.FirstOrDefault(p => p.PatientID == patientId);
            if (patient != null)
            {
                patient.ProgressNotes = notes; // Assuming ProgressNotes is a property in the Patient model
                _context.SaveChanges();
            }
        }
    }
}
