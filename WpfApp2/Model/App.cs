using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WpfApp2.Model
{
    internal class App
    {
        private string _Name;
        private Icon _Icon;
        private string _Adress;
        private bool IsOpened;

        private int _Time;
        DispatcherTimer dispatherTimer;

        public int Timer
        {
            get { return _Time; }
        }

        

        

    }
}
