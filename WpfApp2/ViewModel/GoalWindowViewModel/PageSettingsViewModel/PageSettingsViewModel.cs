using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using WpfApp2.Model;

namespace WpfApp2.ViewModel.GoalWindowViewModel.PageSettingsViewModel
{
    internal class PageSettingsViewModel : ViewModelPageBase
    {
        public SubGoal SubGoal { get; set; }

        public PageSettingsViewModel(SubGoal subGoal)
        {
            SubGoal = subGoal;
        }

        public ICommand OpenSubGoalsDirectoryFiles
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var fileDialog = new SaveFileDialog();
                    fileDialog.Filter = String.Empty;
                    fileDialog.OverwritePrompt = true;

                    if (fileDialog.ShowDialog() == true)
                    {
                        SubGoal.DirectoryOfProject = Path.GetDirectoryName(fileDialog.FileName);
                    }
                    else
                    {
                        return;
                    }

                });
            }
        }
        
        public PageSettingsViewModel()
        {
            
        }
    }
}
