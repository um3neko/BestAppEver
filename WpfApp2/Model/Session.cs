using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    public class Session : SubGoal
    {

        private DateTime _DateOfStart;
        private DateTime _DateOfEnd;

        public DateTime DateOfStart
        {
            get { return _DateOfStart; }
            set { _DateOfStart = value; OnPropertyChanged();}
        }

        public DateTime DateOfEnd
        {
            get { return _DateOfEnd; }
            set { _DateOfEnd = value; OnPropertyChanged();}
        }

        private TimeSpan interval;
        public TimeSpan Interval 
        {
            get { return interval; }
            set { interval = value; OnPropertyChanged();}
        }

        public Session()
        {
            DateOfStart = DateTime.Now;
        }

        public void Stop()
        {
            DateOfEnd = DateTime.Now;
            interval = DateOfEnd - DateOfStart ;
        }


        private String _Description;

        public String SessionDescription
        {
            get { return _Description; }
            set { _Description = value; OnPropertyChanged(); }
        }
    }
}
