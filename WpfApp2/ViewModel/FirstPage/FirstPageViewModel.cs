using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            SubGoal.Add(new SubGoal());
            foreach (var goal in GoalData.GoalsSingletonCollection)
            {
                Goal.Add(goal);
            }


            Peoples = new List<People>();
            Peoples.Add(new People("aleg", 150));
            Peoples.Add(new People("aleg", 250));
            Peoples.Add(new People("aleg", 50));
        }

        public Int32 Percent { get; set; } = 50;
        public ObservableCollection<Goal> Goal { get; set; }
        public ObservableCollection<SubGoal> SubGoal { get; set; }



        public List<People> Peoples {get; set;}

    }

    public class People
    {
        public People(string s, Int32 i)
        {
            Name = s;
            Height = i;
        }
        public String Name { get; set; }
        public Int32 Height { get; set; }
    }
}

