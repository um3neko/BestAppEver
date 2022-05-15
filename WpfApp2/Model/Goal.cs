using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp2.Control;

namespace WpfApp2.Model
{
    [Serializable]
    public class Goal
    {
        
        public String Name { get; set; }
        public String Description { get; set; }
        
        public String Application { get; set; }
        public Icon AppIcon { get; set; }

        public Int32 Sessions { get; set; }

        public Int32 Time { get; set; } 

        public Int32 CurrentTimeGoal { get; set; } 

        public Int32 LVL { get; set; }

        public DateTime DateOfCreation { get; set; }

        private static int i;

        public Goal()
        {
            Name = $"EXAMPLE NAME GOAL {i}";
            Description = $"Exaple {i} Exaple {i} Exaple {i} Exaple {i} Exaple {i} Exaple {i} Exaple {i} ";
            CurrentTimeGoal = 0;
            Sessions = 0;
            Time = 0;
            LVL = 1;
            DateOfCreation = DateTime.Now;
            i++;

        }

        
        

    }
}
