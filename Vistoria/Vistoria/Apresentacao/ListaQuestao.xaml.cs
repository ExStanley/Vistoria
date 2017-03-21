using System;
using System.Collections.ObjectModel;
using Vistoria.DAL;
using Xamarin.Forms;

namespace Vistoria.Apresentacao
{

    public partial class ListaQuestao : ContentPage
    {
        private ObservableCollection<Vistoria.Modelo.Pergunta> Perguntas { get; set; }
        private PerguntaDAL dalPergunta = new PerguntaDAL();
        public ListaQuestao()
        {
            //Perguntas = new PerguntaDAL().GetAllFixo();
            InitializeComponent();
            BindingContext = this;
            Perguntas = dalPergunta.GetAll();
            lvPerguntas.ItemsSource = Perguntas;
        }
        public async void OnRemoverClick(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = mi.CommandParameter as Vistoria.Modelo.Pergunta;
            var opcao = await DisplayAlert("Confirmação de exclusão", "Confirmar excluir o item " + item.Descricao.ToUpper() + "?", "Sim", "Não");
            if (opcao)
            {
                dalPergunta.Delete(item);
                this.lvPerguntas.ItemsSource = dalPergunta.GetAll();
            }
        }
    }

}
