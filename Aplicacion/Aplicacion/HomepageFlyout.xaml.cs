using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomepageFlyout : ContentPage
    {
        public ListView ListView;

        public HomepageFlyout()
        {
            InitializeComponent();

            BindingContext = new HomepageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class HomepageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomepageFlyoutMenuItem> MenuItems { get; set; }

            public HomepageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<HomepageFlyoutMenuItem>(new[]
                {
                    /* aqui colocamos colocamos el mismo nombre que los formularios */
                    /* agregamos el iconsource para las imagenes */
                    new HomepageFlyoutMenuItem { Id = 0, Title = "Home",IconSource = "Home.png", TargetType = typeof(Home) },
                    new HomepageFlyoutMenuItem { Id = 1, Title = "Suscripciones",IconSource = "", TargetType = typeof(Contenido2)},
                    new HomepageFlyoutMenuItem { Id = 2, Title = "Contenido 3",IconSource = "", TargetType = typeof(Contenido3) },
                    new HomepageFlyoutMenuItem { Id = 3, Title = "BMI",IconSource = "", TargetType = typeof(Contenido4)},
                 
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}