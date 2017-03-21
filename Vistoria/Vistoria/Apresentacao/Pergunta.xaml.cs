using System;
using System.Linq;
using Vistoria.DAL;
using Xamarin.Forms;

namespace Vistoria.Apresentacao
{
    public partial class Pergunta : ContentPage
    {
        private PerguntaDAL dalPergunta = new PerguntaDAL();
        public Pergunta()
        {
            InitializeComponent();
            PrepararNovoRegistro();
        }
        public void GravarPergunta(Object sender, EventArgs e)
        {
            var newPergunta = new Modelo.Pergunta()
            {
            };

            if (dalPergunta.Search(c => c.PerguntaId == int.Parse(perguntaId.Text)).Count() > 0)
            {
                newPergunta.PerguntaId = dalPergunta.Search(c => c.PerguntaId == int.Parse(codigo.Text)).FirstOrDefault().PerguntaId;
                dalPergunta.Update(newPergunta);
            }
            else
            {
                newPergunta.PerguntaId = 1;
                if (dalPergunta.GetAll().Count() > 0)
                    newPergunta.PerguntaId = dalPergunta.GetAll().Max(c => c.PerguntaId) + 1;
                dalPergunta.Add(newPergunta);
            }
            PrepararNovoRegistro();
        }
        private void PrepararNovoRegistro()
        {
            var novoId = dalPergunta.GetAll().Max(c => c.PerguntaId) + 1;
            codigo.Text = string.Empty;
            pergunta.Text = string.Empty;
        }
    }
}
