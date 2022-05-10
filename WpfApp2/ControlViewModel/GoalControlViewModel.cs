using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp2.Model;
using WpfApp2.View;
using WpfApp2.View.AddGoal;
using WpfApp2.ViewModel;
namespace WpfApp2.ControlViewModel
{
    internal class GoalControlViewModel : ViewModelBase
    {

        public Goal GoalInstance { get; }
        
        public GoalControlViewModel() {}
        
        public GoalControlViewModel(Goal goal)
        {
            if (goal == null)
            {
                throw new NullReferenceException("Current Control has an empty goal");
            }
            else
            {
                GoalInstance = goal;
                
            }
        }



        

    }
}
