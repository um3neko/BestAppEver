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
using WpfApp2.View.GoalSettingsWindow;
using WpfApp2.ViewModel.SecondPage;

namespace WpfApp2.ViewModel.OpenedGoalViewModel
{
    internal class OpenedGoalViewModel : ViewModelPageBase
    {
        public Goal Goal { get; }
        private SubGoalUserControl _selectedSubGoal;
        public SubGoalUserControl SelectedSubGoal
        {
            get { return _selectedSubGoal;}
            set
            {
                _selectedSubGoal = value;
                if (SelectedSubGoal != null)
                {
                    Anime(new View.SubGoal.SubGoal(SelectedSubGoal.SubGoal));
                }
                
            }
        }

        public ObservableCollection<SubGoalUserControl> SubGoals { get; private set; }

        public OpenedGoalViewModel(Goal goal)
        {
            Goal = goal;
            SubGoals = new ObservableCollection<SubGoalUserControl>();

            foreach (SubGoal subGoal in Goal.SubGoals)
            {
                SubGoals.Add(new SubGoalUserControl(subGoal));
            }

        }

        public OpenedGoalViewModel()
        {
            
        }

        public ICommand AllSubCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    SubGoals.Clear();
                    foreach (SubGoal subGoal in Goal.SubGoals)
                    {
                        SubGoals.Add(new SubGoalUserControl(subGoal));
                    }
                });
            }
        }

        public ICommand CompletedSubsCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    SubGoals.Clear();
                    var CompletedSubs = from subs in Goal.SubGoals
                                        where subs.IsCompleted == true
                                        select subs;

                    foreach (var completedSub in CompletedSubs)
                    {
                        SubGoals.Add(new SubGoalUserControl(completedSub));
                    }

                });
            }
        }
        public ICommand NotCompletedSubsCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    SubGoals.Clear();
                    var CompletedSubs = from subs in Goal.SubGoals
                        where subs.IsCompleted == false
                        select subs;

                    foreach (var completedSub in CompletedSubs)
                    {
                        SubGoals.Add(new SubGoalUserControl(completedSub));
                    }

                });
            }
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
                });
            }
        }
    }
}
