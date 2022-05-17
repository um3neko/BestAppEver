using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;

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
    }
}
