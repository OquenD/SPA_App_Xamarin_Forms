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
    public partial class BMI : ContentPage
    {
        public BMI()
        {
            InitializeComponent();
            BindingContext = new BMIViewModelcs();
        }
    }
}