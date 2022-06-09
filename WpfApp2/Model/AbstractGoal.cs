using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml.Serialization;
using WpfApp2.Data.GoalsCollection;
using WpfApp2.Model.Saving;

namespace WpfApp2.Model
{
    
    public abstract class AbstractGoal : INotifyPropertyChanged
    {

        private String _name;
        public String Name
        {
            get { return _name;}
            set { _name = value; OnPropertyChanged(); }
        }

        private String _description;
        public String Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged(); }
        }

        private String _application;
        public String Application
        {

            get
            {
                return _application;
            }
            set
            {
                if (value.Contains(".exe"))
                {
                    _application = value;
                    OnPropertyChanged();
                }
                else
                {
                    MessageBox.Show("File not exe");
                }
            }
        }
        private String _applicationFull;
        public String ApplicationFull
        {

            get
            {
                return _application;
            }
            set
            {
                if (value.Contains(".exe"))
                {
                    _application = value;
                    OnPropertyChanged();
                }
                else
                {
                    MessageBox.Show("File not exe");
                }
            }
        }
        private Int32 _lvl;

        public virtual Int32 LVL
        {
            get { return _lvl; }
            set { _lvl = value; OnPropertyChanged(); }
        }

        private Int32 _Time;
        public Int32 Time
        {
            get { return _Time; }
            set
            {
                _Time = value;
                OnPropertyChanged();
            }
        }

        public DateTime DateOfCreation { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        
        protected void OnSubGoalLvlUp()
        {
            this.LVL += 1;
        }

        



    }
}
