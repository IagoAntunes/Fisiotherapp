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
    public partial class TelaIniciar : ContentPage
    {
        public string Nome { get; set; }
        public TelaIniciar(String Nome="fulano")
        {
            InitializeComponent();
            this.Nome = Nome;
            lblNome.Text = String.Format("Olá, {0}!", Nome);
        }
        private void goTratamento(Object sender, EventArgs args)
        {
            App.Current.MainPage = new NavigationPage(new TelaTreinar());
        }
    }
}