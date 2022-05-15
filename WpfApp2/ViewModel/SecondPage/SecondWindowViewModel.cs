using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp2.Control;
using WpfApp2.Data.GoalsCollection;
using WpfApp2.Model;
using WpfApp2.View.OpenedGoal;


namespace WpfApp2.ViewModel.SecondPage
{
    /// <summary>
    /// ДОЛЖНЕН БЫЛ БЫТЬ ФРЕЙМ ДЛЯ ВТОРОЙ СТРАНИЦЫ,
    /// НО ТЕПЕРЬ ЭТА ШТУКА ВЫВОДИТ СПИСОК ЦЕЛЕЙ
    /// </summary>
    internal class SecondWindowViewModel : ViewModelPageBase
    {
        /// <summary>
        /// ТУТ ХРОНИТСО ВЫДЕЛЕННЫЙ КОНТРОЛ
        /// </summary>
        public Goals SelectedGoalsControl { get; set; }
        public Page OpenedPage { get; set; }
        
        public SecondWindowViewModel()
        {
            GetGoalsCollectionControl = new ObservableCollection<Goals>();
            if (GoalData.GoalsSingletonCollection != null)
            {
                foreach (var goal in GoalData.GoalsSingletonCollection)
                {
                    SelectedGoalsControl = new Goals(goal);
                    GetGoalsCollectionControl.Add(SelectedGoalsControl);
                    SelectedGoalsControl.MouseDoubleClick += UserControl_MouseDoubleClick;
                }
            }

            

        }
        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            FrameForSecondPageViewModel.FrameForSecondPageViewModel.Instance.CurrentPage = new OpenedGoal(SelectedGoalsControl.Goal);

        }
        
        public ObservableCollection<Goals> GetGoalsCollectionControl { get; }

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
    

