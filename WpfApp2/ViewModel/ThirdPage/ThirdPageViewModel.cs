using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using Tulpep.NotificationWindow;


namespace WpfApp2.ViewModel.ThirdPage
{
    internal class ThirdPageViewModel : ViewModelPageBase
    {
        private String _text;

        public String Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }

        public ICommand HelloCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    PopupNotifier pop = new PopupNotifier();
                    pop.Image = Properties.Resources.comboburst_1;
                    pop.ImageSize = new Size(250, 250);


                    pop.TitleText = "Notify";
                    pop.ContentText = Text;
                    pop.Popup();
                });
            }
        }
    }
}
