using System.Windows.Controls;

namespace WpfApp2.View.FrameForSecondPage
{
    /// <summary>
    /// Логика взаимодействия для FrameForSecondPage.xaml
    /// </summary>
    public partial class FrameForSecondPage : Page
    {
        public FrameForSecondPage()
        {
            InitializeComponent();
            DataContext = new WpfApp2.ViewModel.FrameForSecondPageViewModel.FrameForSecondPageViewModel();
        }

    }
}
