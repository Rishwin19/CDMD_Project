using CDMD_Project.ERRepo;
using CDMD_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CDMD_Project
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        var patientProgressRepo = new ERPatientProgressRepo(new CDMDContext());
        var patientProgressViewModel = new PatientProgressViewModel(patientProgressRepo);
        var patientProgressView = new PatientProgressView
        {
            DataContext = patientProgressViewModel
        };

    }
}
