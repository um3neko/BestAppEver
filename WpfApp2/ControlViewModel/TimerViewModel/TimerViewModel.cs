using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using WpfApp2.ViewModel;

namespace WpfApp2.ControlViewModel
{
    internal class TimerViewModel : ViewModelPageBase
    {
        public TimerViewModel()
        {
            StartTimer(120);
            
        }

        

        public DispatcherTimer Timer { get; set; }


        private int _Seconds;
        public int Waiting
        {
            get => _Seconds; set => Set(ref _Seconds, value);
        }
       



        private double _rotator;

        public double Rotator
        {
            get { return _rotator; }
            set 
            {
                if (value > -360 && value < 0)
                {
                    _rotator = value;
                    OnPropertyChanged();

                }
                else _rotator = 0;
            }
        }



        public void StartTimer(int secodns)
        {
            
            Waiting = secodns;
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);
            Timer.Start();

        }

        private  void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (Waiting == 0)
                Timer.Stop();
            Rotator -= 6;
            Waiting--;
           
        }

    }

}
