using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp2.Control;

namespace WpfApp2.Model
{
    [Serializable]
    public class Goal
    {
        public Page GoalPage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Sessions { get; set; }

        public int Time { get; set; } 

        public int CurrentTimeGoal { get; set; } 

        public int LVL { get; set; }


        public Goal()
        {
            GoalPage = new Page();
            Name = "Exaple";
            Description = "Exaple";
            CurrentTimeGoal = 0;
            Sessions = 0;
            Time = 0;
            LVL = 1;
        }
        

    }
}
