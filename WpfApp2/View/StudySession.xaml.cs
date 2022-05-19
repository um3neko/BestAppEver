using System.Windows;
using WpfApp2.ViewModel;

namespace WpfApp2.View
{
    /// <summary>
    /// Логика взаимодействия для StudySession.xaml
    /// </summary>
    public partial class StudySession : Window
    {
        public StudySession(Model.SubGoal sub)
        {
            InitializeComponent();
            DataContext = new StudySessionViewModel(sub);

        }
    }
}
