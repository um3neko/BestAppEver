using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using WpfApp2.Data.GoalsCollection;
using WpfApp2.Model;

namespace WpfApp2.ViewModel.CalendarPageViewModel
{
    internal class CalendarPageViewModel : ViewModelPageBase
    {
        private String _dateTimeToString;
        public String DateTimeToShort
        {
            get { return _dateTimeToString; }
            set { _dateTimeToString = value; OnPropertyChanged(); } 
        }

        private DateTime _selecteDateTime;
        public DateTime SelectedDateTime
        {
            get { return _selecteDateTime; }
            set 
            { 
                _selecteDateTime = value;
                OnPropertyChanged();
                DateTimeToShort = SelectedDateTime.ToShortDateString();
                SubGoalsCollection.Clear();
                AddAllSubGoalsInObservableCollection(GetCollectionOfAllSubGoals(), SelectedDateTime);
            }
        }

        private SubGoal _selected;
        public SubGoal SelectedSubGoal {get {return _selected;}
            set { _selected = value; OnPropertyChanged(); }
        }

        public ObservableCollection<SubGoal> SubGoalsCollection { get; }

        public CalendarPageViewModel()
        {
            _selecteDateTime = DateTime.Now;
            DateTimeToShort = DateTime.Now.ToShortDateString();
            SubGoalsCollection = new ObservableCollection<SubGoal>();
            AddAllSubGoalsInObservableCollection(GetCollectionOfAllSubGoals(), SelectedDateTime);
            
        }

        


        private void AddAllSubGoalsInObservableCollection(List<SubGoal> subGoals, DateTime dt)
        {
            foreach (var sub in subGoals)
            {
                if (sub.DeadLine == dt)
                {
                    SubGoalsCollection.Add(sub);
                }
                
            }
        }
        private List<SubGoal> GetCollectionOfAllSubGoals()
        {
            List<SubGoal> sub = new List<SubGoal>();
            var e = GoalData.GoalsSingletonCollection.FindAll(goal => goal.SubGoals.Exists(subGoal => true));
            if (e != null)
            {
                foreach (var eb in e)
                {
                    sub.AddRange(eb.SubGoals);
                }
                return sub;
            }
            else
            {
                throw new NullReferenceException("Empty Collection");
            }

           
            
                
        }

        




    }
}
