using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Emergencies : ContentPage
    {
        public Emergencies()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Emergencies";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Emergencies")
                        {
                            new TextCell
                            {
                                Text = "Airway Fire",
                                Command = navigateCommand,
                                CommandParameter = typeof(AirwayFire)
                            },

                            new TextCell
                            {
                                Text = "Anaphylaxis",
                                Command = navigateCommand,
                                CommandParameter = typeof(Anaphylaxis)
                            },

                            new TextCell
                            {
                                Text = "Bronchospasm",
                                Command = navigateCommand,
                                CommandParameter = typeof(Bronchospasm)
                            },

                            new TextCell
                            {
                                Text = "Delayed Emergence",
                                Command = navigateCommand,
                                CommandParameter = typeof(DelayedEmergence)
                            },
                            new TextCell
                            {
                                Text = "Extravasation Injuries",
                                Command = navigateCommand,
                                CommandParameter = typeof(ExtravasationInjuries)
                            },

                            new TextCell
                            {
                                Text = "Fat Embolism",
                                Command = navigateCommand,
                                CommandParameter = typeof(FatEmbolism)
                            },

                            new TextCell
                            {
                                Text = "Hypertension",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hypertension)
                            },

                            new TextCell
                            {
                                Text = "Hypoglycemia",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hypoglycemia)
                            },

                            new TextCell
                            {
                                Text = "Hypotension",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hypotension)
                            },


                            new TextCell
                            {
                                Text = "Hypoxemia",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hypoxemia)
                            },


                            new TextCell
                            {
                                Text = "Increased Airway Pressure",
                                Command = navigateCommand,
                                CommandParameter = typeof(IncreasedAirwayPressure)
                            },


                            new TextCell
                            {
                                Text = "Local Anesthetic Toxicity",
                                Command = navigateCommand,
                                CommandParameter = typeof(LocalAnestheticToxicity)
                            },


                            new TextCell
                            {
                                Text = "Malignant Hyperthermia",
                                Command = navigateCommand,
                                CommandParameter = typeof(MalignantHyperthermia)
                            },


                            new TextCell
                            {
                                Text = "Perioperative MI",
                                Command = navigateCommand,
                                CommandParameter = typeof(PerioperativeMI)
                            },


                            new TextCell
                            {
                                Text = "Seizure",
                                Command = navigateCommand,
                                CommandParameter = typeof(Seizure)
                            },


                            new TextCell
                            {
                                Text = "Postoperative Visual Loss",
                                Command = navigateCommand,
                                CommandParameter = typeof(PostoperativeVisualLoss)
                            },


                            new TextCell
                            {
                                Text = "Total Spinal",
                                Command = navigateCommand,
                                CommandParameter = typeof(TotalSpinal)
                            },


                            new TextCell
                            {
                                Text = "Transfusion Reactions",
                                Command = navigateCommand,
                                CommandParameter = typeof(TransfusionReactions)
                            },


                            new TextCell
                            {
                                Text = "Venous Air Embolism",
                                Command = navigateCommand,
                                CommandParameter = typeof(VenousAirEmbolism)
                            },

                        }
                    }
            };
        }
    }

}

