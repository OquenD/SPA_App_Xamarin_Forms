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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Chrono : ContentPage
    {
        float cents = 0f;
        int seconds = 0;
        Timer myTimer;
        bool activeFlag = false;
        public Chrono()
        {
            InitializeComponent();
            myTimer = new System.Timers.Timer();
            myTimer.Interval = 100;
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
                    myTimer.Enabled = false;
                    labelSeconds.Text = seconds.ToString() + ":00";
                    Device.BeginInvokeOnMainThread(() => buttonActivate.Text = "Activate");
                    buttonActivate.IsEnabled = false;
                    



                }

            }
            cents = (float)Math.Round(cents, 2);
            if (activeFlag == true)// evitar un error de al refrescar dato
            {
                Device.BeginInvokeOnMainThread(() => labelSeconds.Text = seconds.ToString() + ":" + cents.ToString());
            }
        }

        private void stepperSeconds_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            labelLimit.Text = "Time in Seconds: " + stepperSeconds.Value.ToString();
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
    }
}