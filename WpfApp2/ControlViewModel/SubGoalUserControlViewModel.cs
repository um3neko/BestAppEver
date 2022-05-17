using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using WpfApp2.Model;

namespace WpfApp2.ControlViewModel
{
    internal class SubGoalUserControlViewModel : ViewModelBase
    {
        public SubGoal SubGoalInstance { get; }

        public SubGoalUserControlViewModel() { }

        public SubGoalUserControlViewModel(Model.SubGoal subgoal)
        {
            if (subgoal == null)
            {
                throw new NullReferenceException("Current Control has an empty goal");
            }
            else
            {
                SubGoalInstance = subgoal;

            }
        }
    }
}
