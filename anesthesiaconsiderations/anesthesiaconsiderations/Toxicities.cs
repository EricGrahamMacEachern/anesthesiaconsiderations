using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Toxicities : ContentPage
    {
        public Toxicities()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Toxicities";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Toxicities")
                        {
                            new TextCell
                            {
                                Text = "Acetaminophen Overdose",
                                Command = navigateCommand,
                                CommandParameter = typeof(AcetaminophenOverdose)
                            },

                            new TextCell
                            {
                                Text = "ASA Toxicity",
                                Command = navigateCommand,
                                CommandParameter = typeof(ASAToxicity)
                            },

                            new TextCell
                            {
                                Text = "Beta Blocker Overdose",
                                Command = navigateCommand,
                                CommandParameter = typeof(BetaBlockerOverdose)
                            },

                            new TextCell
                            {
                                Text = "Cocaine Toxicity",
                                Command = navigateCommand,
                                CommandParameter = typeof(CocaineToxicity)
                            },

                            new TextCell
                            {
                                Text = "Cyanide Toxicity",
                                Command = navigateCommand,
                                CommandParameter = typeof(CyanideToxicity)
                            },

                            new TextCell
                            {
                                Text = "Digoxin Toxicity",
                                Command = navigateCommand,
                                CommandParameter = typeof(DigoxinToxicity)
                            },

                            new TextCell
                            {
                                Text = "MDMA (Ectasy)",
                                Command = navigateCommand,
                                CommandParameter = typeof(MDMAEcstasy)
                            },

                            new TextCell
                            {
                                Text = "Metamphetamines",
                                Command = navigateCommand,
                                CommandParameter = typeof(Methamphetamines)
                            },

                            new TextCell
                            {
                                Text = "Organophosphates",
                                Command = navigateCommand,
                                CommandParameter = typeof(Organophosphates)
                            },

                            new TextCell
                            {
                                Text = "Tricyclic Antidepressants (TCA)",
                                Command = navigateCommand,
                                CommandParameter = typeof(TricyclicAntidepressantsTCA)
                            },

                        }
                    }
            };
        }
    }

}


