using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class MDMAEctasy : ContentPage
    {
        public MDMAEctasy()
        {
            Label header = new Label
            {
                Text = "MDMA Ectasy",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "MDMA Ectasy",

                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                }
            };



            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    scrollView,
                }
            };
        }
    }
}