using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp2.ViewModel.AddGoal
{
    internal class AddGoalViewModel : ViewModelBase
    {

        private App _app;
        public App Application
        {
            get => _app; private set => Set(ref _app, value);
        }

        public AddGoalViewModel()
        {
            
        }

        public ICommand Open_APP
        {
            get
            {
                return new RelayCommand(() =>
                {
                    _app = new App();
                    
                });
            }
        }

    }
}
