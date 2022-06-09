using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using WpfApp2.Model;
using WpfApp2.View;
using WpfApp2.ViewModel;
namespace WpfApp2.ControlViewModel
{
    internal class GoalControlViewModel : ViewModelBase
    {

        public Goal GoalInstance { get; }
        public Int32 GetSessions { get; }
        public Int32 GetTime { get; set; }
        
        public Int32 GetLvl { get; }
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
                foreach (var sub in GoalInstance.SubGoals)
                {
                    GetSessions += sub.Sessions.Count;
                    GetTime += sub.Time;
                    GetLvl += sub.LVL;
                }
            }
        }

        


        

    }
}
