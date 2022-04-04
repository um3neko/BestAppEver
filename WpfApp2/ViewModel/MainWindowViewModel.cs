using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp2.ViewModel
{
    internal class MainWindowViewModel : ViewModelPageBase
    {
        private Page firstPage;
        private Page secondPage;
        private Page thirdPage;

        private async void Anime3(int width)
        {
            await Task.Factory.StartNew(() =>
            {
                if(width == 150)
                {
                    for (int i = width; i > 10; i -= 10)
                    {
                        StackPanelWidth = i;
                        Thread.Sleep(10);
                    }
                }
                
                if(width == 20)
                {
                    for (int i = width; i < 160; i += 10)
                    {
                        StackPanelWidth = i;
                        Thread.Sleep(10);
                    }
                }

                
            });

        }

        private int _stackPanelWidth;
        public int StackPanelWidth
        {
             get => _stackPanelWidth; set => Set(ref _stackPanelWidth, value); 
        }
        

        private int _currentMargin;
        public int CurrentMargin
        {
            get { return _currentMargin; }
            set { _currentMargin = value; OnPropertyChanged(); }
        }

        public MainWindowViewModel()
        {
            firstPage = new View.FirstPage();
            secondPage = new View.SecondPage();
            thirdPage = new View.ThirdPage();
            _stackPanelWidth = 150;
            
            CurrentOpacity = 1;
               
        }
        public ICommand firstPage_Click
        {
                get
                {
                    return new RelayCommand(() => Anime(firstPage));
            }
        }

        public ICommand secondPage_Click
        {
            get
            {
                return new RelayCommand(() => Anime(secondPage));
            }
        }
        public ICommand thirdPage_Click
        {
            get
            {
                return new RelayCommand(() => Anime(thirdPage));
            }
        }

        public ICommand hideLeftBar
        {
            get
            {
                return new RelayCommand(() => Anime3(_stackPanelWidth));
            }
        }
       
    }
}
