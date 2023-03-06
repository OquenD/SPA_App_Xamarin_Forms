using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using System.Timers;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Aplicacion
{
    public partial class Chrono : ContentPage
    {
        private float cents = 0f;
        private int seconds = 0;
        private Timer myTimer;
        private bool activeFlag = false;

        public Chrono()
        {
            InitializeComponent();

            myTimer = new Timer();
            myTimer.Interval = 100; // refreshes every 100 milliseconds
            myTimer.Enabled = false;
            myTimer.Elapsed += MyTimer_Elapsed;
        }

        private void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            cents += 0.1f;
            if (cents >= 1)
            {
                seconds++;
                cents = 0f;
                if (seconds == (int)stepperSeconds.Value)
                {
                    seconds = 0;
                    myTimer.Stop();
                    activeFlag = false;
                    Device.BeginInvokeOnMainThread(() => labelSeconds.Text = "0:00");
                    Device.BeginInvokeOnMainThread(() => buttonActivate.Text = "Activate");
                }
            }

            cents = (float)Math.Round(cents, 2);
            if (activeFlag == true)
            {
                Device.BeginInvokeOnMainThread(() => labelSeconds.Text = seconds.ToString() + ":" + cents.ToString("00"));
            }
        }

        private void buttonActivate_Clicked(object sender, EventArgs e)
        {
            if (activeFlag == false)
            {
                activeFlag = true;
                buttonActivate.Text = "";
                myTimer.Enabled = true;
                myTimer.Start();
            }
        }

        private void stepperSeconds_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            labelLimit.Text = "Time in Seconds: " + stepperSeconds.Value.ToString();

        }

    }
}