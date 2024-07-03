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

namespace Pomodoro.Views.Controllers
{
    /// <summary>
    /// Interaction logic for TimerButtonControl.xaml
    /// </summary>
    public partial class TimerButtonControl : UserControl
    {
        DispatcherTimer timer;

        public TimerButtonControl()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
    }
}
