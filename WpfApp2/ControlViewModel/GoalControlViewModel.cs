using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp2.Model;
using WpfApp2.View;
using WpfApp2.ViewModel;
namespace WpfApp2.ControlViewModel
{
    internal class GoalControlViewModel : ViewModelBase
    {
        private Goal goalInstance;

        public Goal GoalInstance
        {
            get
            {
                return goalInstance;
            }
            set
            {
                goalInstance = value;
            }
        }

        public string Name { get; set; }

        public string Description { get; set;}

        public int Sessions { get; set; }


        public int Time { get; set; }
        
        public int CurrentTimeGoal { get; set; }
     
        public int LVL { get; set; }
      
      
        public DateTime DateOfCreation { get; set; }
        
       

        public GoalControlViewModel()
        {

        }

        public GoalControlViewModel(Goal goal)
        {
            if (goal == null)
            {
                throw new NullReferenceException("Current Control has an empty goal");
            }
            else
            {
                GoalInstance = goal;
                Name = GoalInstance.Name;
                Description = GoalInstance.Description;
                Time = GoalInstance.Time;
                Sessions = GoalInstance.Sessions;
                CurrentTimeGoal = GoalInstance.CurrentTimeGoal;
                LVL = GoalInstance.LVL;
                DateOfCreation = GoalInstance.DateOfCreation;
            }
        }

        

    }
}
