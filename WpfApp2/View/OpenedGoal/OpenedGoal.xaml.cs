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
using WpfApp2.Model;
using WpfApp2.ViewModel.OpenedGoalViewModel;

namespace WpfApp2.View.OpenedGoal
{
    /// <summary>
    /// Логика взаимодействия для OpenedGoal.xaml
    /// </summary>
    public partial class OpenedGoal : Page
    {
        public OpenedGoal(Goal goal)
        {
            InitializeComponent();
            DataContext = new OpenedGoalViewModel(goal);
        }

        
    }
}
