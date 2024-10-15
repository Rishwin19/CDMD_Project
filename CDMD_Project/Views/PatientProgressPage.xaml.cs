using System.Windows;
using CDMD_Project.ViewModel;
using LiveCharts;

namespace CDMD_Project.Views
{
    public partial class PatientProgressPage : Window
    {
        public PatientProgressPage()
        {
            InitializeComponent();
            DataContext = new PatientProgressViewModel(); // Ensure this points to your ViewModel
        }
    }
}
