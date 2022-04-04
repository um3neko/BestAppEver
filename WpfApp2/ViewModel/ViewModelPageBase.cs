using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp2.ViewModel
{
    internal abstract class ViewModelPageBase : ViewModelBase
    {
        private Page _curentPage;
        public Page CurrentPage
        {
            get { return _curentPage; }
            set { _curentPage = value; OnPropertyChanged(); }
        }

        private double _currentOpacity;
        public double CurrentOpacity
        {
            get { return _currentOpacity; }
            set { _currentOpacity = value; OnPropertyChanged(); }
        }


        protected async void Anime(Page page)
        {
            await Task.Factory.StartNew(() =>
            {
                for (double i = 1.0; i > 0.0; i -= 0.1)
                {
                    CurrentOpacity = i;
                    Thread.Sleep(10);
                }
                CurrentPage = page;
                for (double i = 0.0; i < 1.1; i += 0.1)
                {
                    CurrentOpacity = i;
                    Thread.Sleep(10);
                }
            });
        }

    }
}
