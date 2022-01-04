using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fisiotherapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TratamentoView : ContentPage
    {
        //    public List<Treino> listaTreinos = new List<Treino>()
        //    {
        //        new Treino(){Nome="Treino01",Repeticoes = 10,Descanso = 30},
        //        new Treino(){Nome="Treino02",Repeticoes = 5,Descanso = 10},
        //        new Treino(){Nome="Treino03",Repeticoes = 20,Descanso = 15},
        //        new Treino(){Nome="Treino04",Repeticoes = 30,Descanso = 5},
        //        new Treino(){Nome="Treino05",Repeticoes = 40,Descanso = 40}
        //    };
        //    int index = 0;

        //    public TratamentoView()
        //    {
        //        InitializeComponent();
        //        MudarPropriedades(listaTreinos[0]);
        //    }

        //    private void MudarPropriedades(Treino treinoAtual)
        //    {
        //        lblDescanso.Text = treinoAtual.Descanso.ToString();
        //        lblRepeticoes.Text = treinoAtual.Repeticoes.ToString();
        //    }        
        //    private void goProximoTreino(Object sender,EventArgs args)
        //    {
        //        if (index < listaTreinos.Count) {
        //            MudarPropriedades(listaTreinos[index]);
        //            index++;
        //        }
        //        else
        //        {
        //            DisplayAlert("Fim", "Voce finalizou", "Ok");
        //        }
        //    }

        //}
    }
}