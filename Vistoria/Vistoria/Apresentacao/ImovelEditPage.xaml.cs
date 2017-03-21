using System;
using System.Linq;
using Vistoria.DAL;
using Xamarin.Forms;
using Vistoria.Modelo;

namespace Vistoria.Apresentacao
{

    public partial class ImovelEditPage : ContentPage
    {
        private UnidadeDAL dalUnidade = new UnidadeDAL();
        public ImovelEditPage(Unidade unidade)
        {
            InitializeComponent();
            PopularFormulario(unidade);
        }

        private void PopularFormulario(Unidade unidade)
        {
            this.codigo.Text = unidade.Codigo.ToString();
            this.descricao.Text = unidade.Descricao;
            this.tipo.Text = unidade.Tipo;
            this.endereco.Text = unidade.Endereco;
            this.cep.Text = unidade.CEP;
        }

        public async void GravarImovel(Object sender, EventArgs e)
        {
            var newUnidade = new Unidade()
            {
                Codigo = codigo.Text,
                Descricao = descricao.Text,
                Tipo = tipo.Text,
                Endereco = endereco.Text,
                CEP = cep.Text
            };

            if (dalUnidade.Search(c => c.Codigo == codigo.Text).Count() > 0)
            {
                newUnidade.UnidadeId = dalUnidade.Search(c => c.Codigo == codigo.Text).FirstOrDefault().UnidadeId;
                dalUnidade.Update(newUnidade);
            }
            else
            {
                newUnidade.UnidadeId = 1;
                if (dalUnidade.GetAll().Count() > 0)
                    newUnidade.UnidadeId = dalUnidade.GetAll().Max(c => c.UnidadeId) + 1;
                dalUnidade.Add(newUnidade);
            }
            await Navigation.PopModalAsync();
        }
    }

 
}
