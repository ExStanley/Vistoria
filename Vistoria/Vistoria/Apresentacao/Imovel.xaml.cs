using System;
using System.Linq;
using Vistoria.DAL;
using Vistoria.Modelo;
using Xamarin.Forms;

namespace Vistoria.Apresentacao
{
    public partial class Imovel : ContentPage
    {
        private UnidadeDAL dalUnidade = new UnidadeDAL();

        public Imovel()
        {
            InitializeComponent();
            PrepararNovoRegistro();
        }
        public  void GravarImovel(Object sender, EventArgs e)
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
            PrepararNovoRegistro();
        }
        private void PrepararNovoRegistro()
        {
            var novoId = dalUnidade.GetAll().Max(c => c.UnidadeId) + 1;
            codigo.Text = string.Empty;
            tipo.Text = string.Empty;
            descricao.Text = string.Empty;
            endereco.Text = string.Empty;
            cep.Text = string.Empty;
        }
    }
}
