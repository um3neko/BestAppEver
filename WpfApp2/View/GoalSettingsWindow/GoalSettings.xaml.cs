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
using System.Windows.Shapes;
using WpfApp2.Model;
using WpfApp2.ViewModel.GoalWindowViewModel;

namespace WpfApp2.View.GoalSettingsWindow
{
    /// <summary>
    /// Логика взаимодействия для GoalSettings.xaml
    /// </summary>
    public partial class GoalSettings : Window
    {
        public GoalSettings(Model.SubGoal subgoal)
        {
            InitializeComponent();
            DataContext = new GoalSettingsViewModel(subgoal);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
