using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Considerations : ContentPage
    {
        public Considerations()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Considerations";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Considerations")
                        {
                            new TextCell
                            {
                                Text = "Airway",
                                Command = navigateCommand,
                                CommandParameter = typeof(Airway)
                            },

                            new TextCell
                            {
                                Text = "Cardiac",
                                Command = navigateCommand,
                                CommandParameter = typeof(Cardiac)
                            },

                            new TextCell
                            {
                                Text = "Critical Care",
                                Command = navigateCommand,
                                CommandParameter = typeof(CriticalCare)
                            },

                            new TextCell
                            {
                                Text = "Endocrinology",
                                Command = navigateCommand,
                                CommandParameter = typeof(Endocrinology)
                            },
                            new TextCell
                            {
                                Text = "Hematology",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hematology)
                            },

                            new TextCell
                            {
                                Text = "Hepatic",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hepatic)
                            },

                            new TextCell
                            {
                                Text = "Neuroanesthesia",
                                Command = navigateCommand,
                                CommandParameter = typeof(Neuroanesthesia)
                            },

                            new TextCell
                            {
                                Text = "Neuromuscular",
                                Command = navigateCommand,
                                CommandParameter = typeof(Neuromuscular)
                            },

                            new TextCell
                            {
                                Text = "Obstetrics",
                                Command = navigateCommand,
                                CommandParameter = typeof(Obstetrics)
                            },


                            new TextCell
                            {
                                Text = "Pediatrics",
                                Command = navigateCommand,
                                CommandParameter = typeof(Pediatrics)
                            },


                            new TextCell
                            {
                                Text = "Psychiatric",
                                Command = navigateCommand,
                                CommandParameter = typeof(Psychiatric)
                            },


                            new TextCell
                            {
                                Text = "Rare Co-existing Disease",
                                Command = navigateCommand,
                                CommandParameter = typeof(RareCoexistingDisease)
                            },

                            new TextCell
                            {
                                Text = "Renal",
                                Command = navigateCommand,
                                CommandParameter = typeof(Renal)
                            },


                            new TextCell
                            {
                                Text = "Respiratory & Thoracics",
                                Command = navigateCommand,
                                CommandParameter = typeof(RespiratoryAndThoracics)
                            },


                            new TextCell
                            {
                                Text = "Skin & Musculoskeletal",
                                Command = navigateCommand,
                                CommandParameter = typeof(SkinAndMusculoskeletal)
                            },

                            new TextCell
                            {
                                Text = "Toxicities",
                                Command = navigateCommand,
                                CommandParameter = typeof(Toxicities)
                            },


                            new TextCell
                            {
                                Text = "Vascular",
                                Command = navigateCommand,
                                CommandParameter = typeof(Vascular)
                            },
                        }
                    }
            };
        }
    }

}

