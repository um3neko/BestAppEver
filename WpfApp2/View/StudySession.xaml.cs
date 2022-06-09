using System.Windows;
using WpfApp2.Model;
using WpfApp2.ViewModel;

namespace WpfApp2.View
{
    /// <summary>
    /// Логика взаимодействия для StudySession.xaml
    /// </summary>
    public partial class StudySession : Window
    {
        private Model.SubGoal sub;
        private Session session;
        public StudySession(Session session, Model.SubGoal sub)
        {
            InitializeComponent();
            DataContext = new StudySessionViewModel(session);
            this.sub = sub;
            this.session = session;

        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            sub.Time += session.Interval.Minutes;
        }
    }
}
