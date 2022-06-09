using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using Tulpep.NotificationWindow;

namespace WpfApp2.Model
{
    internal class PopUpNotifer
    {
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
                    pop.Popup();
                });
            }
        }
    }
}
