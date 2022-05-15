using System.Windows.Controls;
using WpfApp2.ViewModel.SecondPage;

namespace WpfApp2.View
{
    /// <summary>
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
            DataContext = new SecondWindowViewModel();
            
        }
    }
}
