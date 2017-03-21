using Vistoria.Apresentacao;
using Xamarin.Forms;

namespace Vistoria
{
    public class HomeTabbedPage : TabbedPage
    {
        public HomeTabbedPage()
        {
            Children.Add(new MenuPage());
            //Children.Add(new ListaVistoria());
            //Children.Add(new Formulario());
            //Children.Add(new Pergunta());
        }

    }
}
