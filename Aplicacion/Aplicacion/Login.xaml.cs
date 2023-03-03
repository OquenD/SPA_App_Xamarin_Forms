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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Asignamos logica para interactura con el usuario y contraseña
            if (TextUserName.Text == "adm" && TextPassword.Text == "123")
            {
                /* llamamos la instancia y agregamos la pagina que deciamos ir*/
                Navigation.PushAsync(new Homepage());
            }
            else
            {
                // Agregamos un mensaje de error si el usuario o contraseña son incorrectos
                DisplayAlert("Ops","Usuario o contraseña incorrecta", "Intetalo de nuevo");
            }

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            /* asignamos la instancia y la el formulario que deciamos ir */
            Navigation.PushAsync(new Register());

        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            /* asignamos la instancia y la el formulario que deciamos ir */
            Navigation.PushAsync(new Recover());
        }
    }
}