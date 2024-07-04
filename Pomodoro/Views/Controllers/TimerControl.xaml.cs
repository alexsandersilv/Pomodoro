using System.Windows.Controls;

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

        public int MinutesL
        {
            get { return int.Parse(MinutesLeft.Text); }
            set { MinutesLeft.Text = value.ToString(); }
        }

        public int MinutesR
        {
            get { return int.Parse(MinutesRight.Text); }
            set { MinutesRight.Text = value.ToString(); }
        }

        public int SecondsL
        {
            get { return int.Parse(SecondsLeft.Text); }
            set { SecondsLeft.Text = value.ToString(); }
        }

        public int SecondsR
        {
            get { return int.Parse(SecondsRight.Text); }
            set { SecondsRight.Text = value.ToString(); }
        }
    }
}
