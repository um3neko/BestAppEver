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
using WpfApp2.ViewModel.GoalWindowViewModel;
using WpfApp2.ViewModel.GoalWindowViewModel.PageSettingsViewModel;

namespace WpfApp2.View.GoalSettingsWindow.SettingsPages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1(Model.SubGoal subgoal)
        {
            InitializeComponent();
            DataContext = new PageSettingsViewModel(subgoal);
        }
    }
}
