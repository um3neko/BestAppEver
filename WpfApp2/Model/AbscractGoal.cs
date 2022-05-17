using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    [Serializable]
    public abstract class AbscractGoal
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Application { get; set; }
        
        

        public Int32 Sessions { get; set; }
        public Int32 Time { get; set; }
        public Int32 CurrentTimeGoal { get; set; }
        public Int32 LVL { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
