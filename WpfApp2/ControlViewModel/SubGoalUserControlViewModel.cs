using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using WpfApp2.Model;

namespace WpfApp2.ControlViewModel
{
    internal class SubGoalUserControlViewModel : ViewModelBase
    {
        public SubGoal Sub { get; }
        public SubGoalUserControlViewModel()
        {
            
        }

        public SubGoalUserControlViewModel(Model.SubGoal subgoal)
        {
           Sub = subgoal;
        }
    }
}
