using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp2.Control;
using WpfApp2.Data.GoalsCollection;
using WpfApp2.Model.Saving;

namespace WpfApp2.Model
{
    [Serializable]
    public class Goal : AbscractGoal
    {
        public List<SubGoal> SubGoals { get; }

        private static Int32 i;
        public Goal()
        {
            SubGoals = new List<SubGoal>();
            Name = $"EXAMPLE NAME GOAL {i}";
            Description = $"Exaple {i} Exaple {i} Exaple {i} Exaple {i} Exaple {i} Exaple {i} Exaple {i} ";
            CurrentTimeGoal = 0;
            Sessions = 0;
            Time = 0;
            LVL = 1;
            DateOfCreation = DateTime.Now;
            ++i;
        }
        public SubGoal CreateSubGoal()
        {
            SubGoal sub = new SubGoal();
            SubGoals.Add(sub);
            return sub;
        }
        

        public static void InitializationOfGoals()
        {
            GoalData.GoalsSingletonCollection = SerializationXml.ReadFromXml();
            
        }
       
    }
    [Serializable]
    public class SubGoal : AbscractGoal
    {
        public static Int32 i;
        public SubGoal()
        {
            Name = $"SubGoal {i}";
            Description = $"SubGoal {i} Description";
            Sessions = 0;
            CurrentTimeGoal = 0;
            DateOfCreation = DateTime.Now;
            ++i;
        }
    }

}
