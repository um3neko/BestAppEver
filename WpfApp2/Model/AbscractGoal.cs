using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfApp2.Model
{
    [Serializable]
    public abstract class AbscractGoal : INotifyPropertyChanged
    {
        public static Int32 Id { get; set; }

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

        public Int32 Sessions { get; set; }
        public Int32 Time { get; set; }

        private Int32 _currentTime;
        public Int32 CurrentTimeGoal
        {
            get { return _currentTime; }
            set { _currentTime = value; OnPropertyChanged(); }
        }


        public Int32 LVL { get; set; }
        public DateTime DateOfCreation { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

    }
}
