﻿using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;
using WpfApp2.ControlViewModel;
using WpfApp2.Data.GoalsCollection;
using WpfApp2.Model;
using WpfApp2.ViewModel.SecondPage;
using WpfApp2.Model.Saving;
using WpfApp2.View;
using WpfApp2.View.CalendarView;
using WpfApp2.View.FrameForSecondPage;

namespace WpfApp2.ViewModel
{
    internal class MainWindowViewModel : ViewModelPageBase
    {
        
        private static Page firstPage;
        private static Page secondPage;
        private static Page thirdPage;
        private static Page fourthgPage;


        /// <summary>
        /// CTOR
        /// </summary>
        public MainWindowViewModel()
        {
            //При запуске считывает XML
            firstPage = new View.FirstPage();
            secondPage = new FrameForSecondPage();
            thirdPage = new View.ThirdPage();
            fourthgPage = new CalendarPage();

            _stackPanelWidth = 150;
            CurrentOpacity = 1;

           

        }


        /// <summary>
        /// ANIMATION
        /// </summary>
        /// <param name="width"></param>
        private async void Anime3(int width)
        {
            await Task.Factory.StartNew(() =>
            {
                if(width == 150)
                {
                    for (int i = width; i > 10; i -= 10)
                    {
                        StackPanelWidth = i;
                        Thread.Sleep(10);
                    }
                }
                
                if(width == 20)
                {
                    for (int i = width; i < 160; i += 10)
                    {
                        StackPanelWidth = i;
                        Thread.Sleep(10);
                    }
                }

                
            });

        }

        private int _stackPanelWidth;
        public int StackPanelWidth
        {
             get => _stackPanelWidth; set => Set(ref _stackPanelWidth, value); 
        }
        

        private int _currentMargin;
        public int CurrentMargin
        {
            get { return _currentMargin; }
            set { _currentMargin = value; OnPropertyChanged(); }
        }


        /// <summary>
        /// PAGES OPEN COMMANDS
        /// </summary>
        public ICommand firstPage_Click
        {
            get
            {
                return new RelayCommand(() => Anime(new FirstPage()));
            }
        }

        public ICommand secondPage_Click
        {
            get
            {
                return new RelayCommand(() => Anime(secondPage));
            }
        }
        public ICommand thirdPage_Click
        {
            get
            {
                return new RelayCommand(() => MessageBox.Show("органайзер привычек в разработке"));
            }
        }
        
        public ICommand hideLeftBar
        {
            get
            {
                return new RelayCommand(() => Anime3(_stackPanelWidth));
            }
        }

        public ICommand fourthPage_Click
        {
            get
            {
                return new GalaSoft.MvvmLight.CommandWpf.RelayCommand(() =>
                {
                    Anime(fourthgPage);
                });
            }
        }

        public ICommand home_click
        {
            get
            {
                return new GalaSoft.MvvmLight.CommandWpf.RelayCommand(() =>
                {
                    Anime(null);
                });
            }
        }



    }
}
