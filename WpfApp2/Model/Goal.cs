using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp2.Control;
using WpfApp2.Data.GoalsCollection;
using WpfApp2.Model.Saving;

namespace WpfApp2.Model
{
    [Serializable]
    public class Goal : AbstractGoal
    {
        public List<SubGoal> SubGoals { get; }
        /// <summary>
        /// COUNTER
        /// </summary>
        private static Int32 i;

        public Goal()
        {
            SubGoals = new List<SubGoal>();
            Name = $"EXAMPLE NAME GOAL {i}";
            Description = $"Exaple {i} Exaple {i} Exaple {i} Exaple {i} Exaple {i} Exaple {i} Exaple {i} ";
            DateOfCreation = DateTime.Now;
            ++i;
        }


        public SubGoal CreateSubGoal()
        {
            SubGoal sub = new SubGoal();
            SubGoals.Add(sub);
            return sub;
        }

    }
    [Serializable]
    public class SubGoal : Goal
    {
        private ObservableCollection<Session> _sessions;
        public ObservableCollection<Session> Sessions
        {
            get { return _sessions; }
            set
            {
                _sessions = value; 
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// COUNTER
        /// </summary>
        private static Int32 i;


        

        private String _directoryOfProject;
        public String DirectoryOfProject
        {
            get { return _directoryOfProject; }
            set { _directoryOfProject = value; OnPropertyChanged(); }
        }

        private DateTime? _deadLine;
        public DateTime? DeadLine
        { 
            get { return _deadLine; } 
            set { _deadLine = value; OnPropertyChanged(); }
        }



        private bool _isCompleted;
        public bool IsCompleted
        {
            get { return _isCompleted; }
            set
            {
                _isCompleted = value;
                OnPropertyChanged();

                if (IsCompleted == true)
                {
                   // OnSubGoalLvlUp();
                }
            }
        }
        
        private Int32 _Priority;
        public Int32 Priority
        {
            get { return _Priority; }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    _Priority = value;
                    OnPropertyChanged();
                }
            }
        }

        public void AddSession(Session ses)
        {
            Sessions.Add(ses);
        }
        
        public SubGoal()
        {
            Name = $"SubGoal {i}";
            Description = $"SubGoal {i} Description";
            DirectoryOfProject = null;
            Sessions = new ObservableCollection<Session>();
            IsCompleted = false;
            DeadLine = null;
            Time = 0;
            DateOfCreation = DateTime.Now;
            Priority = 0;
            ++i;
            
        }

        
    }

}
