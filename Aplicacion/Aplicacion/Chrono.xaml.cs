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
        float centesimas = 0f;
        int segundos = 0;
        Timer miTimer;
        bool banderaActivo = false;
        public Chrono()
        {
            InitializeComponent();
            miTimer = new System.Timers.Timer();
            miTimer.Interval = 100;
            miTimer.Enabled = false;
            miTimer.Elapsed += MiTimer_Elapsed;
        }

        private void MiTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            centesimas += 0.1f;
            if (centesimas >= 1)
            {
                segundos++;
                centesimas = 0f;
                if (segundos == (int)stepperSegundos.Value)
                {
                    banderaActivo = false;
                    segundos = 0;
                    miTimer.Stop();
                    miTimer.Enabled = false;
                    labelSegundos.Text = segundos.ToString() + ":00";
                    Device.BeginInvokeOnMainThread(() => buttonActivar.Text = "Activate");
                   
                    
                }

            }
            centesimas = (float)Math.Round(centesimas, 2);
            if (banderaActivo == true)// evitar un error de al refrescar dato
            {
                Device.BeginInvokeOnMainThread(() => labelSegundos.Text = segundos.ToString() + ":" + centesimas.ToString());
            }
        }

        private void stepperSegundos_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            labelLimite.Text = "Time in Seconds: " + stepperSegundos.Value.ToString();
        }

        private void buttonActivar_Clicked(object sender, EventArgs e)
        {
            if (banderaActivo == false)
            {
                banderaActivo = true;
                buttonActivar.Text = "Activate";
                miTimer.Enabled = true;
                miTimer.Start();

            }

        }
    }
}