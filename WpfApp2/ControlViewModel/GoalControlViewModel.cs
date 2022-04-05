using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp2.Model;
using WpfApp2.View;
using WpfApp2.ViewModel;
namespace WpfApp2.ControlViewModel
{
    internal class GoalControlViewModel : ViewModelBase
    {
        public Goal _Goal { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int Sessions { get; set; }
        public int Time { get; set; }
        public int CurrentTimeGoal { get; set; }
        public int LVL { get; set; }
        public App Application { get; set; }

       

        public GoalControlViewModel()
        {
            _Goal= new Goal();

            Name = _Goal.Name;
            Description = _Goal.Description;
            Sessions = _Goal.Sessions;
            Time = _Goal.Time;
            CurrentTimeGoal = _Goal.CurrentTimeGoal;
            LVL = _Goal.LVL;
            
        }
    }
}
