using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public PageSettingsViewModel()
        {
            
        }
    }
}
