using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp2.Control;
using WpfApp2.ControlViewModel;
using WpfApp2.Model;
using WpfApp2.ViewModel.SecondPage.ControlFactory;

namespace WpfApp2.ViewModel
{
    internal class SecondWindowViewModel : ViewModelPageBase
    {

        public SecondWindowViewModel()
        {
            GetGoals = new ObservableCollection<Goals>();
        }

        private ObservableCollection<Goals> _goalsCollection;

        public ObservableCollection<Goals> GetGoals
        {
            get { return _goalsCollection; }
            set { _goalsCollection = value; }
        }

        public ICommand createGoal
        {
            get
            {
                return new RelayCommand(() => CreateControlGoals());
            }
        }

        private void CreateControlGoals()
        {
            
            GetGoals.Add(new Goals());
           
            
        }
    }


}
    

