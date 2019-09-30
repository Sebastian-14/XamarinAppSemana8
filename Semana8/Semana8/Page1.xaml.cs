using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            var layout = new StackLayout();
                var yellowBox = new BoxView { Color = Color.Red, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
                var greenBox = new BoxView { Color = Color.SkyBlue, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
                var blueBox = new BoxView
                {
                    Color = Color.Blue,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    HeightRequest = 75
                };
                layout.Children.Add(yellowBox);
                layout.Children.Add(greenBox);
                layout.Children.Add(blueBox);
                layout.Spacing = 10;
                Content = layout;
        }
    }
}