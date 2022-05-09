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
        public Goal Goal { get; }
        public string Name { get; }
        public string Description { get; }
        public int Sessions { get; }
        public int Time { get; }
        public int CurrentTimeGoal { get; }
        public int LVL { get; }
        public App Application { get; }
        public DateTime DateOfCreation { get; }
        
        public GoalControlViewModel()
        {
            
            this.DateOfCreation = DateTime.Now;
        }
    }
}
