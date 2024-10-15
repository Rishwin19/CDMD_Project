using CDMD_Project.ViewModel;
using System.Windows;

namespace CDMD_Project.View
{
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
            DataContext = new LoginPageViewModel();
        }
    }
}
