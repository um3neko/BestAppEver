using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    internal class Goal
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Sessions { get; set; }

        public int Time { get; set; } 

        public int CurrentTimeGoal { get; set; } 

        public int LVL { get; set; }

        public App Application { get; set; }

        public Goal()
        {
            Sessions = 0;
            Time = 0;
            LVL = 1;
        }
        

    }
}
