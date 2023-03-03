using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            // instanciamos para pasar de formularios
            MainPage = new NavigationPage (new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
