using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;
using WpfApp2.Model.Saving;

namespace WpfApp2.Data.GoalsCollection
{
    [Serializable]
    internal static class GoalData
    {
        
        private static List<Goal> _listGoal;

        public static List<Goal> GoalsSingletonCollection { get; set; }
    

    }
}
