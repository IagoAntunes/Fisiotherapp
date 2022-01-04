using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Fisiotherapp.PaginasCSharp
{
    public class TelaInicio2 : ContentPage
    {
        public TelaInicio2()
        {
            
            Image imagem = new Image { Source = "pessoaFisioterapia.png",HorizontalOptions=LayoutOptions.Center,VerticalOptions=LayoutOptions.Center};

            Label lblNome = new Label {Text="Olá, !" ,FontSize = 30,HorizontalTextAlignment=TextAlignment.Center, Margin = new Thickness(0, 0, 0, 40) };
            Label lblTexto = new Label { Text="Vamos iniciar o seu tratamento",FontSize = 30,HorizontalTextAlignment=TextAlignment.Center,
            Margin = new Thickness(0, 0, 0, 40)};

            Button botao = new Button { Text = "Iniciar Tratamento", BackgroundColor = Color.Purple,TextColor=Color.White,FontSize=14,
            HorizontalOptions=LayoutOptions.Center,VerticalOptions=LayoutOptions.Center,WidthRequest=250,CornerRadius=10};

            botao.Clicked += OnButtonClicked;


            StackLayout stackLabel = new StackLayout
            {
                Children =
                {
                    lblNome,
                    lblTexto
                }
            };
            StackLayout stackPrincipal = new StackLayout
            {
                Padding = 30,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    imagem,
                    stackLabel,
                    botao
                }
            };
            Content = stackPrincipal;
        }

        private void OnButtonClicked(Object sender,EventArgs args)
        {
            App.Current.MainPage = new NavigationPage(new TelaTreinar2());
        }
    }
}
