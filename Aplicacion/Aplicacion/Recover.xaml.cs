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
	public partial class Recover : ContentPage
	{
		public Recover ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "The recovery link has been sent to your email", "Ok");

        }
    }
}