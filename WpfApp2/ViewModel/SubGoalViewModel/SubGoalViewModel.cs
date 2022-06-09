using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        private double _opacity;
        public double Opacity
        {
            get { return _opacity;}
            set { _opacity = value; OnPropertyChanged(); }
        } 
        

        public SubGoalViewModel(SubGoal subGoal)
        {
            SubGoal = subGoal;
            Opacity = 1.0;

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

        public ICommand OpenFolderCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    Process.Start("explorer.exe", $"{SubGoal.DirectoryOfProject}");
                });
            }
        }

        public ICommand OpenCalendarCommand
        {
            get { return new RelayCommand(() => MessageBox.Show("Calendar")); }
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
                        SubGoal.ApplicationFull = fileDialog.FileName;
                    }
                    else
                    {
                        return;
                    }

                });
            }
        }

        private static int Counter = 0;
        public ICommand ThisCompleteCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (Counter % 2 == 0)
                    {
                        SubGoal.IsCompleted = true;
                        MessageBox.Show($"{SubGoal.Name} is Completed");
                        Opacity = 0.4;
                        Counter++;
                    }
                    else
                    {
                        SubGoal.IsCompleted = false;
                        MessageBox.Show($"{SubGoal.Name} is Not Completed");
                        Opacity = 1;
                        Counter++;
                    }

                });
            }
        }
    }
}
