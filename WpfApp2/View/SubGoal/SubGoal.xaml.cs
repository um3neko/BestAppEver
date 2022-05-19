using System.Windows.Controls;
using WpfApp2.Model;
using WpfApp2.ViewModel.SubGoalViewModel;

namespace WpfApp2.View.SubGoal
{
    /// <summary>
    /// Логика взаимодействия для SubGoal.xaml
    /// </summary>
    public partial class SubGoal : Page
    {
        private Model.SubGoal _sub;
        public SubGoal(Model.SubGoal subGoal)
        {
            InitializeComponent();
            _sub = subGoal;
            DataContext = new SubGoalViewModel(subGoal);
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StudySession session = new StudySession(_sub);
            session.Show();
        }
    }
}
