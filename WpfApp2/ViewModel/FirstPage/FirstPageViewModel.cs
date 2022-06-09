using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using WpfApp2.Data.GoalsCollection;
using WpfApp2.Model;

namespace WpfApp2.ViewModel
{
    internal class FirstPageViewModel : ViewModelBase
    {
        public FirstPageViewModel()
        {
            Goal = new ObservableCollection<Goal>();
            SubGoal = new ObservableCollection<SubGoal>();
            Session = new ObservableCollection<Session>();

            

            SubGoal.Add(new SubGoal());
            try
            {
                foreach (var goal in GoalData.GoalsSingletonCollection)
                {
                    Goal.Add(goal);
                    foreach (var sub in goal.SubGoals)
                    {
                        SubGoal.Add(sub);
                        foreach (var session in sub.Sessions)
                        {
                            Session.Add(session);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Exc");
            }
        }

        public ObservableCollection<Goal> Goal { get; set; }
        public ObservableCollection<SubGoal> SubGoal { get; set; }
        public ObservableCollection<Session> Session { get; set; }

        private SubGoal _topSubGoal;

        public SubGoal TopSubGoal
        {
            get { return _topSubGoal; }
            set
            {
                _topSubGoal = value;
                OnPropertyChanged();
            }
        }
        

        public ObservableCollection<SubGoal> TopGoals { get; set; }

        //private void TopGoalAndSubGoal()
        //{
        //    var topGoals = from p in people // передаем каждый элемент из people в переменную p
        //        where p.ToUpper().StartsWith("T") //фильтрация по критерию
        //        orderby p  // упорядочиваем по возрастанию
        //        select p; // выбираем объект в создаваемую коллекцию
        //}
    }

   
}

