using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Fisiotherapp.PaginasCSharp
{
    public class TelaTreinar2 : ContentPage
    {
        public List<Treino> listaTreinos = new List<Treino>()
        {
            new Treino(){Nome="Treino01",Repeticoes= 10,Descanso = 30},
            new Treino(){Nome="Treino02",Repeticoes= 20,Descanso = 50},
            new Treino(){Nome="Treino03",Repeticoes= 30,Descanso = 20}
        };
        public Label lblValorRepeticoes;
        public Label lblValorDescanso;
        public int index;
        public TelaTreinar2()
        {


            Image imagem = new Image() { Source = "maoFisioterapia.png" };
            Label descricao = new Label() { Text = "Fechar e abrir as mãos", FontSize = 30, TextColor = Color.White, HorizontalTextAlignment = TextAlignment.Center };
            Button botao = new Button()
            {
                Text = "Feito!",
                BackgroundColor = Color.Purple,
                TextColor = Color.White,
                FontSize = 26,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 250,
                CornerRadius = 10
            };
            botao.Clicked += goProximoTreino;


            StackLayout stackSuperior = new StackLayout()
            {
                HeightRequest = 450,
                Children =
                {
                    imagem,
                    descricao,
                    botao
                }
            };

            Grid grid = new Grid()
            {
                HeightRequest = 250,
                RowDefinitions = {
                new RowDefinition(),
                new RowDefinition()
            },
                ColumnDefinitions =
            {
                new ColumnDefinition(),
                new ColumnDefinition(){Width=130},
                new ColumnDefinition(){Width=120}
            }
            };

            Label lblSeries = new Label()
            {
                Text = "Series",
                FontSize = 25,
                HorizontalTextAlignment = TextAlignment.Center
            };
            Label lblValorSeries = new Label
            {
                Text = "",
                FontSize = 22,
                TextColor = Color.Purple,
                HorizontalTextAlignment = TextAlignment.Center,
                FontAttributes = FontAttributes.Bold
            };

            Label lblRepeticoes = new Label
            {
                Text = "Repetições",
                FontSize = 25,
                HorizontalTextAlignment = TextAlignment.Center
            };
            lblValorRepeticoes = new Label
            {
                Text = "10",
                FontSize = 22,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Purple,
                FontAttributes = FontAttributes.Bold
            };

            Label lblDescanso = new Label
            {
                Text = "Descanso",
                FontSize = 25,
                HorizontalTextAlignment = TextAlignment.Center
            };
            lblValorDescanso = new Label
            {
                Text = "",
                FontSize = 22,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Purple,
                FontAttributes = FontAttributes.Bold
            };
            
            StackLayout stackGrid1 = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    lblSeries, 
                    lblValorSeries
                }
            };
            StackLayout stackGrid2 = new StackLayout()
            {
                HorizontalOptions=LayoutOptions.CenterAndExpand,
                VerticalOptions=LayoutOptions.CenterAndExpand,
                Children =
                {
                    lblRepeticoes,
                    lblValorRepeticoes
                }
            };
            StackLayout stackGrid3 = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    lblDescanso,
                    lblValorDescanso
                }
            };
            Grid.SetColumn(stackGrid1, 0);
            Grid.SetColumn(stackGrid2, 1);
            Grid.SetColumn(stackGrid3, 2);

            grid.Children.Add(stackGrid1);
            grid.Children.Add(stackGrid2);
            grid.Children.Add(stackGrid3);

            StackLayout stackPrincipal = new StackLayout() {
                Padding = 30,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Spacing = 0,
                Children =
                {
                    stackSuperior,
                    grid
                }
            };
            Content = stackPrincipal;
            index = 0;
            MudarPropriedade(listaTreinos[0]);
            index++;
        }
    
    
        private void MudarPropriedade(Treino treinoAtual)
        {
            lblValorDescanso.Text = treinoAtual.Descanso.ToString();
            lblValorRepeticoes.Text = treinoAtual.Repeticoes.ToString();
        }
        private void goProximoTreino(object sender,EventArgs args)
        {
            if(index < listaTreinos.Count)
            {
                MudarPropriedade(listaTreinos[index]);
                index++;
            }
            else
            {
                App.Current.MainPage = new PaginasCSharp.TelaInicio2();
            }
        }
    }
}
