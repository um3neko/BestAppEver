using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp2.Control;
using WpfApp2.ControlViewModel;
using WpfApp2.Data.GoalsCollection;
using WpfApp2.Model;
using WpfApp2.View.AddGoal;


namespace WpfApp2.ViewModel.SecondPage
{
    internal class SecondWindowViewModel : ViewModelPageBase
    {
        private Page _fullOpenedGoalPage;
        public Page FullOpenedGoalPage
        {
            get
            {
                return _fullOpenedGoalPage;
            }
            set
            {
                _fullOpenedGoalPage = value;
                OnPropertyChanged();
            }
        }

        public Goals GoalsControl { get; set; }

        public SecondWindowViewModel()
        {
            GetGoalsCollectionControl = new ObservableCollection<Goals>();
            if (GoalData.GoalsSingletonCollection != null)
            {
                foreach (var goal in GoalData.GoalsSingletonCollection)
                {
                    GoalsControl = new Goals(goal);
                    GetGoalsCollectionControl.Add(GoalsControl);
                    GoalsControl.MouseDoubleClick += UserControl_MouseDoubleClick;
                }
            }

        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            //MessageBox.Show($"Double Click + {GoalsControl.Goal.Name}");
            
            FullOpenedGoalPage = new OpenedGoal(GoalsControl.Goal);
            Anime(FullOpenedGoalPage);
        }

          
        
        public static ObservableCollection<Goals> GetGoalsCollectionControl { get; private set; }

        /// <summary>
        /// CREATE GOAL
        /// </summary>
        public ICommand CreateGoalCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var goal = new Goal();
                    GoalData.GoalsSingletonCollection.Add(goal);

                    var goalControl = new Goals(goal);
                    goalControl.MouseDoubleClick += UserControl_MouseDoubleClick;
                    GetGoalsCollectionControl.Add(goalControl);

                });
            }
        }


    }


}
    

