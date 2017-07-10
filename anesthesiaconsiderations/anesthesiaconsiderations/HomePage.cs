using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class HomePage : ContentPage
    {
        public HomePage()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Anesthesia Considerations";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Menu")
                        {
                            new TextCell
                            {
                                Text = "About",
                                Command = navigateCommand,
                                CommandParameter = typeof(About)
                            },

                            new TextCell
                            {
                                Text = "Emergencies",
                                Command = navigateCommand,
                                CommandParameter = typeof(Emergencies)
                            },

                            new TextCell
                            {
                                Text = "Considerations",
                                Command = navigateCommand,
                                CommandParameter = typeof(Considerations)
                            },

                            new TextCell
                            {
                                Text = "Legal",
                                Command = navigateCommand,
                                CommandParameter = typeof(Legal)
                            },
                            new TextCell
                            {
                                Text = "Contact",
                                Command = navigateCommand,
                                CommandParameter = typeof(Contact)
                            },
                            new TextCell
                            {
                                Text = "Search",
                                Command = navigateCommand,
                                CommandParameter = typeof(Search)
                            },

                        }
                    }
            };
        }
    }

}

