using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Airway : ContentPage
    {
        public Airway()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Airway";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Airway")
                        {
                            new TextCell
                            {
                                Text = "Airway Abscess & Infection",
                                Command = navigateCommand,
                                CommandParameter = typeof(AirwayAbscessAndInfection)
                            },

                            new TextCell
                            {
                                Text = "Airway Trauma",
                                Command = navigateCommand,
                                CommandParameter = typeof(AirwayTrauma)
                            },

                            new TextCell
                            {
                                Text = "Expanding Neck Hematoma",
                                Command = navigateCommand,
                                CommandParameter = typeof(ExpandingNeckHematoma)
                            },

                            new TextCell
                            {
                                Text = "Microlaryngoscopy & Airway Laser",
                                Command = navigateCommand,
                                CommandParameter = typeof(MicrolaryngoscopyAndAirwayLaser)
                            },

                            new TextCell
                            {
                                Text = "Penetrating Neck Injuries",
                                Command = navigateCommand,
                                CommandParameter = typeof(PenetratingNeckInjuries)
                            },

                            new TextCell
                            {
                                Text = "Rigid Bronchoscopy",
                                Command = navigateCommand,
                                CommandParameter = typeof(RigidBronchoscopy)
                            },

                            new TextCell
                            {
                                Text = "Tracheostomy",
                                Command = navigateCommand,
                                CommandParameter = typeof(Tracheostomy)
                            },

                        }
                    }
            };
        }
    }

}

