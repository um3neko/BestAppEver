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
using WpfApp2.Data.GoalsCollection;
using WpfApp2.Model;
using WpfApp2.Model.Saving;
using WpfApp2.ViewModel;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public  MainWindow()
        {
            GoalData.ReadFromXml();
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }


        private void Window_Closed(object sender, EventArgs e)
        {
            GoalData.SaveToXml();
        }
    }
}
