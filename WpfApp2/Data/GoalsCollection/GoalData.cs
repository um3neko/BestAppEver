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
    internal class GoalData
    {
        
        private static GoalData _instance;
        
        private GoalData()
        {
            GoalsSingletonCollection = new List<Goal>();
        }
        public static GoalData Instance => 
            _instance ?? (_instance = new GoalData());


        private static List<Goal> _listGoal;

        public static List<Goal> GoalsSingletonCollection { get; set; }
    

    }
}
