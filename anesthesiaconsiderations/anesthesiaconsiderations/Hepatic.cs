using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Hepatic : ContentPage
    {
        public Hepatic()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Hepatic";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Hepatic")
                        {
                            new TextCell
                            {
                                Text = "End Stage Liver Disease",
                                Command = navigateCommand,
                                CommandParameter = typeof(Cirrhosis)
                            },

                        }
                    }
            };
        }
    }

}

