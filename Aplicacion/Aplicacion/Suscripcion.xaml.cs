using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contenido2 : ContentPage
    {
        public Contenido2()
        {
            InitializeComponent();
        }

       private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Yay", "Gracias por suscribirse !", "Ok");
               
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            

        }
        private void CbXamarinFan_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
                
        }
    }
}