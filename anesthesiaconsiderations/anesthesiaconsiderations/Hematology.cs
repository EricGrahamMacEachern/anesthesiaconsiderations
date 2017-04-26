using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Hematology : ContentPage
    {
        public Hematology()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Hematology";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Hematology")
                        {
                            new TextCell
                            {
                                Text = "Acute Leukemia",
                                Command = navigateCommand,
                                CommandParameter = typeof(AcuteLeukemia)
                            },

                            new TextCell
                            {
                                Text = "G6PD Deficiency",
                                Command = navigateCommand,
                                CommandParameter = typeof(G6PDDeficiency)
                            },

                            new TextCell
                            {
                                Text = "Disseminated Intravascular Coagulation (DIC)",
                                Command = navigateCommand,
                                CommandParameter = typeof(DisseminatedIntravascularCoagulationDIC)
                            },

                            new TextCell
                            {
                                Text = "Hemophilia",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hemophilia)
                            },

                            new TextCell
                            {
                                Text = "Jehova's Witness Patients",
                                Command = navigateCommand,
                                CommandParameter = typeof(JehovasWitnessPatients)
                            },

                            new TextCell
                            {
                                Text = "Sickle Cell Disease",
                                Command = navigateCommand,
                                CommandParameter = typeof(SickleCellDisease)
                            },

                            new TextCell
                            {
                                Text = "Thalassemia",
                                Command = navigateCommand,
                                CommandParameter = typeof(Thalassemia)
                            },

                            new TextCell
                            {
                                Text = "Tumor Lysis Syndrome",
                                Command = navigateCommand,
                                CommandParameter = typeof(TumorLysisSyndrome)
                            },


                            new TextCell
                            {
                                Text = "Von Willebrand's Disease",
                                Command = navigateCommand,
                                CommandParameter = typeof(VonWillebrandsDisease)
                            },

                        }
                    }
            };
        }
    }

}

