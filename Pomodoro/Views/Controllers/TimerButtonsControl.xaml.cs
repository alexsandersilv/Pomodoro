// TimerButtonsControl.xaml.cs
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Pomodoro.Views.Controllers
{
    public partial class TimerButtonsControl : UserControl
    {
        private DispatcherTimer timer;
        private bool _isRunning = false;
        private TimerControl timerControl;

        public TimerButtonsControl()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        public void InitializeTimerControl(TimerControl timerControl)
        {
            this.timerControl = timerControl;
        }

        private void PlayAndPause_Click(object sender, RoutedEventArgs e)
        {
            if (!_isRunning)
            {
                PlayTimer();
            }
            else
            {
                PauseTimer();
            }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            StopTimer();
        }

        private void Timer_Tick(object sender, EventArgs e) 
        {
            int minutes = int.Parse(timerControl.MinutesUI.Text);
            int seconds = int.Parse(timerControl.SecondsUI.Text);

            if (seconds == 0)
            {
                if (minutes == 0)
                {
                    PauseTimer();
                    return;
                }

                minutes--;
                seconds = 59;
            }
            else
            {
                seconds--;
            }

            if (seconds < 10)
            {
                timerControl.SecondsUI.Text = "0" + seconds.ToString();
            }
            else
            {
                timerControl.SecondsUI.Text = seconds.ToString();
            }

            if (minutes < 10)
            {
                timerControl.MinutesUI.Text = "0" + minutes.ToString();
            }
            else
            {
                timerControl.MinutesUI.Text = minutes.ToString();
            }

        }

        private void PlayTimer()
        {
            timer.Start();
            _isRunning = true;
            IconsPlayPause.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/pause.png"));
        }

        private void PauseTimer()
        {
            timer.Stop();
            _isRunning = false;
            IconsPlayPause.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/play.png"));
        }

        private void StopTimer()
        {
            PauseTimer();
            timerControl.MinutesUI.Text = "15";
            timerControl.SecondsUI.Text = "00";
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            if (int.Parse(timerControl.MinutesUI.Text) <= 55)
            {
                timerControl.MinutesUI.Text = (int.Parse(timerControl.MinutesUI.Text.ToString()) + 5).ToString();
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(timerControl.MinutesUI.Text) >= 6)
            {
                timerControl.MinutesUI.Text = (int.Parse(timerControl.MinutesUI.Text.ToString()) - 5).ToString();
                if (int.Parse(timerControl.MinutesUI.Text) < 10)
                {
                    timerControl.MinutesUI.Text = "0" + timerControl.MinutesUI.Text.ToString();
                }
            }

            
          

           
        }
    }
}
