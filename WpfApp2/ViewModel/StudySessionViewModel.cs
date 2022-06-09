using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using GalaSoft.MvvmLight.CommandWpf;
using WpfApp2.Control;
using WpfApp2.Model;

namespace WpfApp2.ViewModel
{
    internal class StudySessionViewModel : ViewModelPageBase
    {
        
        
        private Session session;
        public Session Session
        {
            get { return session; }
            
        }

        public StudySessionViewModel(Session session)
        {
            this.session = session;

        }
        public StudySessionViewModel()
        {
            
        }

        

        public ICommand StopTimerCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    session.Stop();
                    MessageBox.Show($"{session.Interval}");
                    
                });
            }
        }
    }
}
