using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fisiotherapp.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaLogin : ContentPage
    {
        public TelaLogin()
        {
            InitializeComponent();
        }
        private void GoTelaIncio(object sender,EventArgs args)
        {
            App.Current.MainPage = new Paginas.TelaIniciar(entryNome.Text);
        }
    }
}