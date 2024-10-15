using CDMD_Project.Commands;
using CDMD_Project.EFRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CDMD_Project.ViewModel
{
    public class TreatmentPlanViewModel : BaseViewModel
    {
        private readonly ERTreatmentPlanRepo _repo;

        public string Medications { get; set; }
        public string DietPlan { get; set; }
        public string ExercisePlan { get; set; }

        public ICommand SavePlanCommand { get; }

        public TreatmentPlanViewModel(ERTreatmentPlanRepo repo)
        {
            _repo = repo;
            SavePlanCommand = new RelayCommand(SavePlan);
        }

        private void SavePlan()
        {
            // Create a new TreatmentPlan object
            var treatmentPlan = new TreatmentPlan
            {
                PatientID = 1, // Example patientId, replace with actual logic
                DoctorID = 1,  // Example doctorId
                PlanDetails = "Personalized treatment plan",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3),
                Medications = Medications,
                DietPlan = DietPlan,
                ExercisePlan = ExercisePlan,
                FollowUpDate = DateTime.Now.AddMonths(1),
                CreatedAt = DateTime.Now
            };

            // Save the treatment plan via the repository
            _repo.SaveTreatmentPlan(treatmentPlan);
        }
    }


}
