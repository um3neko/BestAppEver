using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp2.Control;
using WpfApp2.Data.GoalsCollection;
using WpfApp2.Model;
using WpfApp2.View.AddGoal;


namespace WpfApp2.ViewModel.SecondPage
{
    internal class SecondWindowViewModel : ViewModelPageBase
    {
        private Page openedGoal;
        public SecondWindowViewModel()
        {
            GetGoalsCollectionControl = new ObservableCollection<Goals>();

            if (GoalData.GoalsSingletonCollection != null)
            {
                foreach (var goal in GoalData.GoalsSingletonCollection)
                {
                    var goalControl = new Goals(goal);
                    GetGoalsCollectionControl.Add(goalControl);
                }
            }
            
              
        }

        
        public static ObservableCollection<Goals> GetGoalsCollectionControl { get; private set; }

        public ICommand CreateGoalCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    
                    var goal = new Goal();
                    GoalData.GoalsSingletonCollection.Add(goal);

                    var goalContol = new Goals(goal);
                    GetGoalsCollectionControl.Add(goalContol);

                });
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
    

