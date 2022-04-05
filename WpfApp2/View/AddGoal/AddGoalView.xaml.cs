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
using WpfApp2.ViewModel.AddGoal;

namespace WpfApp2.View.AddGoal
{
    /// <summary>
    /// Логика взаимодействия для AddGoalView.xaml
    /// </summary>
    public partial class AddGoalView : Window
    {
        public AddGoalView()
        {
            InitializeComponent();
            DataContext = new AddGoalViewModel();

        }
    }
}
