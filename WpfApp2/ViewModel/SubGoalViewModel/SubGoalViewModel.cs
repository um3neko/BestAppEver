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

namespace WpfApp2.ViewModel.SubGoalViewModel
{
    internal class SubGoalViewModel : ViewModelPageBase
    {
        public SubGoal SubGoal{get; }
        public String Name
        {
            get
            {
                return SubGoal.Name;
            }
            set
            {
                SubGoal.Name = value;
                OnPropertyChanged();
            }
        }

        private String _Description;

        public String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
                OnPropertyChanged("Description");
            }
        }


        private String _Application;

        public String Application
        {

            get
            {
                return _Application;
            }

            private set
            {
                if (value.Contains(".exe"))
                {
                    _Application = value;
                    OnPropertyChanged("Application");
                }
                else
                {
                    MessageBox.Show("File not exe");
                }
                

            }
        }

        public Int32 Sessions { get; set; }
        public Int32 Time { get; set; }
        public Int32 CurrentTimeGoal { get; set; }
        public Int32 LVL { get; set; }
        public DateTime DateOfCreation { get; set; }


        public SubGoalViewModel(SubGoal subGoal)
        {
            SubGoal = subGoal;
            Name= subGoal.Name;
            Description= subGoal.Description;
            _Application = subGoal.Application;
            Sessions = subGoal.Sessions;
            Time = subGoal.Time;
            CurrentTimeGoal = subGoal.CurrentTimeGoal;
            LVL = subGoal.LVL;
            DateOfCreation = subGoal.DateOfCreation;

        }

        public SubGoalViewModel()
        {
            
        }

        public ICommand AddAppCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    OpenFileDialog fileDialog = new OpenFileDialog();
                    fileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
                    fileDialog.FilterIndex = 1;
                    fileDialog.ShowDialog();
                    SubGoal.Application = fileDialog.SafeFileName;
                    
                    

                });
            }
        }
    }
}
