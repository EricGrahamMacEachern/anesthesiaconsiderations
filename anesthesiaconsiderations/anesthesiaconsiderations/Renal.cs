using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Renal : ContentPage
    {
        public Renal()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Renal";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Renal")
                        {
                            new TextCell
                            {
                                Text = "Acute Renal Failure",
                                Command = navigateCommand,
                                CommandParameter = typeof(AcuteRenalFailure)
                            },

                            new TextCell
                            {
                                Text = "Chronic Renal Failure",
                                Command = navigateCommand,
                                CommandParameter = typeof(ChronicRenalFailure)
                            },

                            new TextCell
                            {
                                Text = "TURP & TURP Syndrome",
                                Command = navigateCommand,
                                CommandParameter = typeof(TURPAndTURPSyndrome)
                            },

                        }
                    }
            };
        }
    }

}


