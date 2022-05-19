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


        private void Selector_OnSelected(object sender, RoutedEventArgs e)
        {
            
        }
        private void ListViewGoals_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            if (!e.Handled)
            {
                e.Handled = true;
                var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
                eventArg.RoutedEvent = UIElement.MouseWheelEvent;
                eventArg.Source = sender;
                var parent = ((System.Windows.Controls.Control)sender).Parent as UIElement;
                parent.RaiseEvent(eventArg);
            }
        }
    }
}
