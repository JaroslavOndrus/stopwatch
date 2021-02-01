using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace stopwatch1
{
    public partial class MainPage : ContentPage
    {
        Stopwatch stopwatch;

        public MainPage()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();

            lblStopWatch.Text = "00:00:00.00000";

        }

        private void buttonStart_Clicked(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();

                Device.StartTimer(TimeSpan.FromMilliseconds(1), () =>
                {
                    lblStopWatch.Text = stopwatch.Elapsed.ToString();

                    if (!stopwatch.IsRunning)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

                );
            }
        }

        private void buttonStop_Clicked(object sender, EventArgs e)
        {
            buttonStart.Text = "Resume";
            stopwatch.Stop();
        }

        private void buttonReset_Clicked(object sender, EventArgs e)
        {
            lblStopWatch.Text = "00:00:00.00000";
            buttonStart.Text = "Start";
            stopwatch.Reset();
        }

        private void ButtonLap_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
