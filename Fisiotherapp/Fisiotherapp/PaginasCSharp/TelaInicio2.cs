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
            StackLayout stackPrincipal = new StackLayout { Orientation = StackOrientation.Vertical,HorizontalOptions=LayoutOptions.Center,VerticalOptions=LayoutOptions.Center};
            var button = new Button { Text = "Ola mundo", WidthRequest = 300 ,BackgroundColor=Color.Green};

            stackPrincipal.Children.Add(button);
            Content = stackPrincipal;

        }
    }
}
