using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;
using GalaSoft.MvvmLight.CommandWpf;
using WpfApp2.Control;
using WpfApp2.Model;
using WpfApp2.Model.Timer;

namespace WpfApp2.ViewModel
{
    internal class StudySessionViewModel : ViewModelPageBase
    {
        private SubGoal _subGoal;
        public SubGoal SubGoal { get; set; }


        private StudyTimer _timer;


        public StudySessionViewModel(SubGoal subGoal)
        {
            _timer = new StudyTimer(subGoal);
            SubGoal = subGoal;
        }

        public StudySessionViewModel()
        {
            
        }

        public ICommand StartTimerCommand
        {
            get
            {
                return new RelayCommand((() =>
                {
                    _timer.Start();
                }));
            }
        }

        public ICommand StopTimerCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    _timer.Stop();
                });
            }
        }
    }
}
