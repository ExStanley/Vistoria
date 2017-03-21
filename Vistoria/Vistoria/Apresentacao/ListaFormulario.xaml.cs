using System;
using System.Collections.ObjectModel;
using Vistoria.DAL;
using Xamarin.Forms;

namespace Vistoria.Apresentacao
{
    public partial class ListaFormulario : ContentPage
    {
        public ObservableCollection<Vistoria.Modelo.Formulario> Formularios { get; set; }
        private FormularioDAL dalFormulario = new FormularioDAL();
        public ListaFormulario()
        {

            InitializeComponent();
            BindingContext = this;
            //Formularios = new FormularioDAL().GetAllFixo();
            lvFormularios.ItemsSource = dalFormulario.GetAll();
        }
        public async void OnRemoverClick(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = mi.CommandParameter as Vistoria.Modelo.Formulario;
            var opcao = await DisplayAlert("Confirmação de exclusão", "Confirmar excluir o item " + item.Descricao.ToUpper() + "?", "Sim", "Não");
            if (opcao)
            {
                dalFormulario.Delete(item);
                this.lvFormularios.ItemsSource = dalFormulario.GetAll();
            }
        }
    }
}
