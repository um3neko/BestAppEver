using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Win32;
using WpfApp2.Model;

namespace WpfApp2.ViewModel.OpenedGoalViewModel
{
    internal class OpenedGoalViewModel : ViewModelPageBase
    {

        public Goal Goal { get; set; }
       
        

        public bool Editing { get; private set; } = false;

        public OpenedGoalViewModel(Goal goal)
        {
            Goal = goal;
        }

        public OpenedGoalViewModel()
        {
            
        }

        public ICommand AddApp
        {
            get
            {
                return new RelayCommand(() =>
                {
                    OpenFileDialog fileDialog = new OpenFileDialog();
                    fileDialog.ShowDialog();
                    Goal.Application = fileDialog.SafeFileName;
                    
                });
            }
        }
        public ICommand Setttings
        {
            get
            {
                return new RelayCommand(() =>
                {
                    
                });
            }
        }
    }
}
