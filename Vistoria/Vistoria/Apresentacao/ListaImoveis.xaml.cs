using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistoria.DAL;
using Vistoria.Modelo;
using Xamarin.Forms;

namespace Vistoria.Apresentacao
{
    public partial class ListaImoveis : ContentPage
    {
        public ObservableCollection<Unidade> Unidades { get; set; }
        private UnidadeDAL dalUnidade = new UnidadeDAL();

        public ListaImoveis()
        {
            InitializeComponent();
            BindingContext = this;
            //Unidades = new UnidadeDAL().GetAllFixo();
            lvImoveis.ItemsSource = dalUnidade.GetAll();

        }

        public async void OnRemoverClick(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = mi.CommandParameter as Unidade;
            var opcao = await DisplayAlert("Confirmação de exclusão", "Confirmar excluir o item " + item.Descricao.ToUpper() + "?", "Sim", "Não");
            if (opcao)
            {
                dalUnidade.Delete(item);
                this.lvImoveis.ItemsSource = dalUnidade.GetAll();
            }
        }

        public async void OnAlterarClick(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = mi.CommandParameter as Unidade;
            await Navigation.PushModalAsync(new ImovelEditPage(item));
        }
    }
}
