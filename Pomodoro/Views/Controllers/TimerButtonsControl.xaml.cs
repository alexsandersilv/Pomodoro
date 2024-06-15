using System;
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
using System.Windows.Threading;
using System.Timers;
using System.Diagnostics;

namespace Pomodoro.Views.Controllers
{
    /// <summary>
    /// Interaction logic for TimerButtonsControl.xaml
    /// </summary>
    public partial class TimerButtonsControl : UserControl
    {

        private DispatcherTimer timer;
        private bool _isRunning = false;

        public TimerButtonsControl()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMicroseconds(1000);

        }


        private void PlayAndPause_Click(object sender, RoutedEventArgs e)
        {
            if (!_isRunning) 
            { 
                _isRunning = true;
                timer.Start();
                IconsPlayPause.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/pause.png"));

            }
            else
            {
                _isRunning = false;
                timer.Stop();
                IconsPlayPause.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/play.png"));
            }
        }

        private void PlayTimer()
        {
            

        }

        private void StopTimer() 
        {
        
        }


    }
}
