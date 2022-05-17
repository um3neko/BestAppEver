using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.ControlViewModel;
using WpfApp2.Model;

namespace WpfApp2.Control
{
    /// <summary>
    /// Логика взаимодействия для SubGoalUserControl.xaml
    /// </summary>
    public partial class SubGoalUserControl : UserControl
    {
        public SubGoal SubGoal { get; }
        public SubGoalUserControl(SubGoal subGoal)
        {
            InitializeComponent();
            DataContext = new SubGoalUserControlViewModel(subGoal);
            SubGoal = subGoal;
        }
    }
}
