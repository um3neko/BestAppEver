using System.Runtime.CompilerServices;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp2.ViewModel.SecondPage;

namespace WpfApp2.ViewModel.FrameForSecondPageViewModel
{
    internal class FrameForSecondPageViewModel : ViewModelPageBase
    {
        public Page SecondPage { get; }
        
        public FrameForSecondPageViewModel()
        {
            Anime(new View.SecondPage());
            Instance = this;
        }

        public static FrameForSecondPageViewModel Instance;
       

        private void CurrentPageChanger(Page page)
        {
            Anime(CurrentPage);
        }
        
        public ICommand ReturnCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    Anime(new View.SecondPage());
                    
                });
            }
        }

        

    }
}
