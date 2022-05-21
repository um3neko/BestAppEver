using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WpfApp2.Model.Timer
{
    internal class StudyTimer
    {
        private DispatcherTimer timer;
        private SubGoal subGoal;
        public StudyTimer(SubGoal subGoal)
        {
            this.subGoal = subGoal;
            timer = new DispatcherTimer
            {
                Interval = new TimeSpan(0,0,0,1)
            };
            timer.Tick += new EventHandler(timer_Tick);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                subGoal.CurrentTimeGoal += 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        


    }
}
