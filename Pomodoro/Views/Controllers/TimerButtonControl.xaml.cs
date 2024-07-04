using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows;

namespace Pomodoro.Views.Controllers
{
    /// <summary>
    /// Interaction logic for TimerButtonControl.xaml
    /// </summary>
    public partial class TimerButtonControl : UserControl
    {
        DispatcherTimer timer;

        TimerControl timerControl;
        bool isActive;
        public TimerButtonControl()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            isActive = false;

        }

        public void InitializeTimerControl(TimerControl timerControl)
        {
            this.timerControl = timerControl;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int minutesLeft = timerControl.MinutesL;
            int minutesRight = timerControl.MinutesR;

            int secondsLeft = timerControl.SecondsL;
            int secondsRight = timerControl.SecondsR;

            if (secondsLeft == 0 && secondsRight == 0)
            {
                if (minutesLeft == 0 && minutesRight == 0)
                {
                    timer.Stop();
                }
                else
                {
                    HandleMinutes();
                }
            }
            else
            {
                HandleSeconds(secondsLeft, secondsRight);
            }
        }

        private void HandleSeconds(int secondsL, int secondsR)
        {
            if (secondsR == 0)
            {
                secondsR = 9;
                secondsL--;
            }
            else
            {
                secondsR--;
            }

            timerControl.SecondsL = secondsL;
            timerControl.SecondsR = secondsR;
        }

        private void HandleMinutes()
        {
            int minutesLeft = timerControl.MinutesL;
            int minutesRight = timerControl.MinutesR;

            if (minutesRight == 0)
            {
                if (minutesLeft > 0)
                {
                    minutesRight = 9;
                    minutesLeft--;
                }
            }
            else
            {
                minutesRight--;
            }

            timerControl.MinutesL = minutesLeft;
            timerControl.MinutesR = minutesRight;
            timerControl.SecondsL = 5;
            timerControl.SecondsR = 9;
        }

        private void HandleResetTimer()
        {
            timerControl.MinutesL = 1;
            timerControl.MinutesR = 5;
            timerControl.SecondsL = 0;
            timerControl.SecondsR = 0;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (isActive == false)
            {
                Start.Content = "Stop Timer";
                timer.Start();
                isActive = true;
            }
            else
            {
                HandleResetTimer();
                Start.Content = "Start Timer";
                timer.Stop();
                isActive = false;
            }

        }
    }
}
