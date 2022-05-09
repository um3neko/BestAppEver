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
using WpfApp2.View;
using WpfApp2.ViewModel.AddGoal;

namespace WpfApp2.Control
{
    /// <summary>
    /// Логика взаимодействия для Goals.xaml
    /// </summary>
    public partial class Goals : UserControl
    {
        public Goals(Goal goal)
        {
            InitializeComponent();
            DataContext = new GoalControlViewModel(goal);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
