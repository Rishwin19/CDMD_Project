using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMD_Project.EFRepo
{
    public class ERTreatmentPlanRepo : ITreatmentPlanRepo
    {
        private readonly CDMDContext _context;

        public ERTreatmentPlanRepo(CDMDContext context)
        {
            _context = context;
        }

        public void SaveTreatmentPlan(TreatmentPlan treatmentPlan)
        {
            _context.TreatmentPlans.Add(treatmentPlan);
            _context.SaveChanges();
        }

        public TreatmentPlan GetTreatmentPlanByPatient(int patientId)
        {
            return _context.TreatmentPlans.FirstOrDefault(tp => tp.PatientID == patientId);
        }
    }

}
