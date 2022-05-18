using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Win32;
using WpfApp2.Model;
using WpfApp2.View.GoalSettingsWindow;

namespace WpfApp2.ViewModel.SubGoalViewModel
{
    internal class SubGoalViewModel : ViewModelPageBase
    {
        public SubGoal SubGoal{get; }

        public SubGoalViewModel(SubGoal subGoal)
        {
            SubGoal = subGoal;

        }

        public SubGoalViewModel()
        {
            
        }

        public ICommand SettingsClick
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var goalSetiings = new GoalSettings(SubGoal);
                    goalSetiings.ShowDialog();
                });
            }
        }
        

        public ICommand AddAppCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                   
                    var fileDialog = new OpenFileDialog
                    {
                        Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*",
                        FilterIndex = 1
                    };

                    if (fileDialog.ShowDialog() == true)
                    {
                        SubGoal.Application = fileDialog.SafeFileName;
                    }
                    else
                    {
                        return;
                    }
                    
                    

                });
            }
        }
    }
}
