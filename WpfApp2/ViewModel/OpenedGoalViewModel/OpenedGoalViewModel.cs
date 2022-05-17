using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Win32;
using WpfApp2.Control;
using WpfApp2.Data.GoalsCollection;
using WpfApp2.Model;
using WpfApp2.ViewModel.SecondPage;

namespace WpfApp2.ViewModel.OpenedGoalViewModel
{
    internal class OpenedGoalViewModel : ViewModelPageBase
    {
        public Goal Goal { get; }
        public SubGoalUserControl SelectedSubGoal { get; set; }
        public ObservableCollection<SubGoalUserControl> SubGoals { get; }

        public OpenedGoalViewModel(Goal goal)
        {
            Goal = goal;
            SubGoals = new ObservableCollection<SubGoalUserControl>();
            foreach (SubGoal subGoal in Goal.SubGoals)
            {
                SelectedSubGoal = new SubGoalUserControl(subGoal);
                SubGoals.Add(SelectedSubGoal);
                SelectedSubGoal.MouseDoubleClick += SelectedSubGoalMouseDoubleClock;
            }
        }

        private void SelectedSubGoalMouseDoubleClock(object sender, MouseButtonEventArgs e)
        {
            Anime(new View.SubGoal.SubGoal(SelectedSubGoal.SubGoal));

        }

        public OpenedGoalViewModel()
        {
            
        }
       


        public ICommand AddSubGoal
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var subgoal = Goal.CreateSubGoal();
                    SelectedSubGoal = new SubGoalUserControl(subgoal);
                    SubGoals.Add(SelectedSubGoal);
                    SelectedSubGoal.MouseLeftButtonUp += SelectedSubGoalMouseDoubleClock;

                });
            }
        }
    }
}
