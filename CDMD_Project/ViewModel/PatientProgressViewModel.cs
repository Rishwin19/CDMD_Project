using CDMD_Project.Commands;
using CDMD_Project.Repo;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CDMD_Project.ViewModel
{
    public class PatientProgressViewModel : BaseViewModel
    {
        private readonly IProgressRepo _progressRepo;

        public ObservableCollection<HealthMetric> HealthMetrics { get; set; }
        public ICommand SaveNotesCommand { get; set; }
        public string Notes { get; set; } // Assuming this is bound to a TextBox in XAML

        public PatientProgressViewModel(IProgressRepo progressRepo)
        {
            _progressRepo = progressRepo;
            HealthMetrics = new ObservableCollection<HealthMetric>();
            LoadPatientProgress(); // Load data when the ViewModel is instantiated
            SaveNotesCommand = new RelayCommand(SaveNotes);
        }

        private void LoadPatientProgress()
        {
            var metrics = _progressRepo.GetProgressByPatient(CurrentPatientId); // Assuming you have a way to get the current patient ID
            foreach (var metric in metrics)
            {
                HealthMetrics.Add(metric);
            }
        }

        private void SaveNotes()
        {
            _progressRepo.SaveNotes(CurrentPatientId, Notes); // Save notes for the current patient
        }
    }
}
