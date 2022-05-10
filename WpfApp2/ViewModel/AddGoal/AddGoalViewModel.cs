using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp2.Model;

namespace WpfApp2.ViewModel.AddGoal
{
    internal class AddGoalViewModel : ViewModelBase
    {
        public Goal GoalForAddGoalViewModel { get; set; }


        public bool Editing { get; private set; } = false;

        public AddGoalViewModel()
        {
            
        }

        public AddGoalViewModel(Goal goal)
        {
            GoalForAddGoalViewModel = goal;
        }

        

    }
}
