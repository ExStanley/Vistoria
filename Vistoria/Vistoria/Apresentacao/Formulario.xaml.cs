using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistoria.DAL;
using Xamarin.Forms;

namespace Vistoria.Apresentacao
{
    public partial class Formulario : ContentPage
    {
        private FormularioDAL dalFormulario = new FormularioDAL();
        public Formulario()
        {
            InitializeComponent();
            PrepararNovoRegistro();
        }
        public void GravarFormulario(Object sender, EventArgs e)
        {
            var newForm = new Modelo.Formulario()
            {
                Codigo = codigo.Text,
                Descricao = descricao.Text,
                Nome = formulario.Text,
                TipoImovel = tipo.Text,
                DataVistoria = DateTime.Now
            };

            if (new FormularioDAL().Search(c => c.Codigo == codigo.Text).Count() > 0)
            {
                newForm.FormularioId = dalFormulario.Search(c => c.Codigo == codigo.Text).FirstOrDefault().FormularioId;
                dalFormulario.Update(newForm);
            }
            else
            {
                newForm.FormularioId = 1;
                if (dalFormulario.GetAll().Count() > 0)
                    newForm.FormularioId = dalFormulario.GetAll().Max(c=>c.FormularioId) + 1;
                dalFormulario.Add(newForm);
            }
            PrepararNovoRegistro();
        }
        private void PrepararNovoRegistro()
        {
            var novoId = dalFormulario.GetAll().Max(c => c.FormularioId) + 1;
            codigo.Text = string.Empty;
            formulario.Text = string.Empty;
            tipo.Text = string.Empty;
            descricao.Text = string.Empty;
        }
        public async void AdicionarQuestao(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestaoPage());
        }
    }
}
