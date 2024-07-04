using Pomodoro.Views.Controllers;
using System.Windows;

namespace Pomodoro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            timerButtonControl.InitializeTimerControl(timerControl);
        }
    }
}
