using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class CriticalCare : ContentPage
    {
        public CriticalCare()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "CriticalCare";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Critical Care")
                        {
                            new TextCell
                            {
                                Text = "Abdominal Compartment Syndrome",
                                Command = navigateCommand,
                                CommandParameter = typeof(AbdominalCompartmentSyndrome)
                            },

                            new TextCell
                            {
                                Text = "ARDS",
                                Command = navigateCommand,
                                CommandParameter = typeof(ARDS)
                            },

                            new TextCell
                            {
                                Text = "Burns",
                                Command = navigateCommand,
                                CommandParameter = typeof(Burns)
                            },

                            new TextCell
                            {
                                Text = "Crush Injuries",
                                Command = navigateCommand,
                                CommandParameter = typeof(CrushInjuries)
                            },

                            new TextCell
                            {
                                Text = "Drowning",
                                Command = navigateCommand,
                                CommandParameter = typeof(Drowning)
                            },

                            new TextCell
                            {
                                Text = "Organ Donation",
                                Command = navigateCommand,
                                CommandParameter = typeof(OrganDonation)
                            },

                            new TextCell
                            {
                                Text = "Sepsis",
                                Command = navigateCommand,
                                CommandParameter = typeof(Sepsis)
                            },

                            new TextCell
                            {
                                Text = "Smoke Inhalation",
                                Command = navigateCommand,
                                CommandParameter = typeof(SmokeInhalation)
                            },

                            new TextCell
                            {
                                Text = "Trauma",
                                Command = navigateCommand,
                                CommandParameter = typeof(Trauma)
                            },

                        }
                    }
            };
        }
    }

}

