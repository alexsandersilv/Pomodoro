﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pomodoro.Views.Controllers
{
    /// <summary>
    /// Interaction logic for TimerControl.xaml
    /// </summary>
    public partial class TimerControl : UserControl
    {

        public TimerControl()
        {
            InitializeComponent();
        }

        public TextBlock MinutesTextBlock
        {
            get { return MinutesUI; }
        }

        public TextBlock SecondsTextBlock
        {
            get { return SecondsUI; }
        }

    }
}
