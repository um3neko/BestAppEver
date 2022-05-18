using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using WpfApp2.Model;
using WpfApp2.View.GoalSettingsWindow.SettingsPages;

namespace WpfApp2.ViewModel.GoalWindowViewModel
{
    internal class GoalSettingsViewModel : ViewModelPageBase
    {
        private Page1 page1;
        private Page2 page2;
        private Page3 page3;

        public SubGoal SubGoal { get; set; }
        public GoalSettingsViewModel()
        {
           
        }

        public GoalSettingsViewModel(SubGoal subgoal)
        {
            SubGoal = subgoal;
        }

        public ICommand FirstPageCommand
        {
            get
            {
                return new RelayCommand(() => Anime(new Page1(SubGoal)));
            }
        }
        public ICommand SecondPageCommand
        {
            get
            {
                return new RelayCommand(() => Anime(new Page2()));
            }
        }
        public ICommand ThirdPageCommand
        {
            get
            {
                return new RelayCommand(() => Anime(new Page3()));
            }
        }


    }
}
