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
    public partial class Subscription : ContentPage
    {
        public Subscription()
        {
            InitializeComponent();
        }

       private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "Thank you for subscribing!", "Ok");
               
        }

        private void CbXamarinFan_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
                
        }
    }
}