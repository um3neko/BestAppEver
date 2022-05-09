using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp2.ViewModel
{
    internal class FirstPageViewModel : ViewModelBase
    {
        public FirstPageViewModel()
        {
            
        }
        private int _anime;
        public int Anime
        {
            get => _anime; set => Set(ref _anime, value);
        }



    }
}
