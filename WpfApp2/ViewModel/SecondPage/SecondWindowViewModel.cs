using System.Collections.Generic;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp2.Control;
using WpfApp2.Model;
using WpfApp2.View.AddGoal;


namespace WpfApp2.ViewModel.SecondPage
{
    internal class SecondWindowViewModel : ViewModelPageBase
    {
        private Page openedGoal;
        

        public SecondWindowViewModel(List<Goal> goals)
        {
            
            openedGoal = new OpenedGoal();
        }

        public ListView ListViewForGoalCollection{ get; set; }
        
        private static ObservableCollection<Goals> _goalsCollection;
        
        public static ObservableCollection<Goals> GetGoalsCollectionControl
        {
            get { return _goalsCollection; }
            set { _goalsCollection = value; }
        }

        public ICommand CreateGoalCommand
        {
            get
            {
                return new RelayCommand(() => GetGoalsCollectionControl.Add(new Goals()));
            }
        }
        

        public ICommand OpenGoalCommand
        {
            get
            {
                return new RelayCommand(() => Anime(openedGoal));
            }
        }
    }


}
    

