using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class RareCoexistingDisease : ContentPage
    {
        public RareCoexistingDisease()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Rare Coexisting Disease";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Rare Coexisting Disease")
                        {
                            new TextCell
                            {
                                Text = "Amyloidosis",
                                Command = navigateCommand,
                                CommandParameter = typeof(Amyloidosis)
                            },

                            new TextCell
                            {
                                Text = "Glycogen Storage Disorders",
                                Command = navigateCommand,
                                CommandParameter = typeof(GlycogenStorageDisorders)
                            },

                            new TextCell
                            {
                                Text = "Hereditary Angioedema (C1 Esterase Deficiency)",
                                Command = navigateCommand,
                                CommandParameter = typeof(HereditaryAngioedemaC1EsteraseDeficiency)
                            },

                            new TextCell
                            {
                                Text = "Hereditary Hemorrhagic Telangiectasias",
                                Command = navigateCommand,
                                CommandParameter = typeof(HereditaryHemorrhagicTelangiectasias)
                            },
                            new TextCell
                            {
                                Text = "Huntington's Disease",
                                Command = navigateCommand,
                                CommandParameter = typeof(HuntingtonsDisease)
                            },

                            new TextCell
                            {
                                Text = "Neurofibromatosis",
                                Command = navigateCommand,
                                CommandParameter = typeof(Neurofibromatosis)
                            },

                            new TextCell
                            {
                                Text = "Periodic Paralysis",
                                Command = navigateCommand,
                                CommandParameter = typeof(PeriodicParalysis)
                            },

                        }
                    }
            };
        }
    }

}


