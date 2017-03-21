using System;

using Xamarin.Forms;

namespace Vistoria.Apresentacao
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void ListaOnImoveisOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ImovelPage());
        }
        private async void ListaFormularioOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new FormularioPage());
        }

    }
}
