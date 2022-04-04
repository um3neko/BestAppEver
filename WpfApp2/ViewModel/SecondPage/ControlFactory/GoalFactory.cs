using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Control;

namespace WpfApp2.ViewModel.SecondPage.ControlFactory
{
    internal class GoalFactory : IGoalFactory
    {
        public object CreateGoal()
        {
            return new WpfApp2.Control.Goals();
             
        }
   }

}
