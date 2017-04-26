using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class RespiratoryAndThoracics : ContentPage
    {
        public RespiratoryAndThoracics()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Respiratory & Thoracics";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Respiratory & Thoracics")
                        {
                            new TextCell
                            {
                                Text = "Anterior Mediastinal Mass",
                                Command = navigateCommand,
                                CommandParameter = typeof(AnteriorMediastinalMass)
                            },

                            new TextCell
                            {
                                Text = "Asthma",
                                Command = navigateCommand,
                                CommandParameter = typeof(Asthma)
                            },

                            new TextCell
                            {
                                Text = "Bronchiectasis",
                                Command = navigateCommand,
                                CommandParameter = typeof(Bronchiectasis)
                            },

                            new TextCell
                            {
                                Text = "Bronchopleural Fistula",
                                Command = navigateCommand,
                                CommandParameter = typeof(BronchopleuralFistula)
                            },

                            new TextCell
                            {
                                Text = "Bullous Lung Disease",
                                Command = navigateCommand,
                                CommandParameter = typeof(BullousLungDisease)
                            },

                            new TextCell
                            {
                                Text = "COPD",
                                Command = navigateCommand,
                                CommandParameter = typeof(COPD)
                            },

                            new TextCell
                            {
                                Text = "Cystic Fibrosis",
                                Command = navigateCommand,
                                CommandParameter = typeof(CysticFibrosis)
                            },

                            new TextCell
                            {
                                Text = "Esophagectomy",
                                Command = navigateCommand,
                                CommandParameter = typeof(Esophagectomy)
                            },

                            new TextCell
                            {
                                Text = "Lung Cancer",
                                Command = navigateCommand,
                                CommandParameter = typeof(LungCancer)
                            },

                            new TextCell
                            {
                                Text = "Massive Hemoptysis",
                                Command = navigateCommand,
                                CommandParameter = typeof(MassiveHemoptysis)
                            },

                            new TextCell
                            {
                                Text = "Mediastinoscopy",
                                Command = navigateCommand,
                                CommandParameter = typeof(Mediastinoscopy)
                            },

                            new TextCell
                            {
                                Text = "Obstructive Sleep Apnea",
                                Command = navigateCommand,
                                CommandParameter = typeof(ObstructiveSleepApnea)
                            },

                            new TextCell
                            {
                                Text = "Pneumonectomy",
                                Command = navigateCommand,
                                CommandParameter = typeof(Pneumonectomy)
                            },

                            new TextCell
                            {
                                Text = "Post Lung Transplant",
                                Command = navigateCommand,
                                CommandParameter = typeof(PostLungTransplant)
                            },

                            new TextCell
                            {
                                Text = "Pulmonary Embolism",
                                Command = navigateCommand,
                                CommandParameter = typeof(PulmonaryEmbolism)
                            },

                            new TextCell
                            {
                                Text = "Restrictive Lung Disease",
                                Command = navigateCommand,
                                CommandParameter = typeof(RestrictiveLungDisease)
                            },

                            new TextCell
                            {
                                Text = "Smoking",
                                Command = navigateCommand,
                                CommandParameter = typeof(Smoking)
                            },

                            new TextCell
                            {
                                Text = "Thymectomy",
                                Command = navigateCommand,
                                CommandParameter = typeof(Thymectomy)
                            },
                        }
                    }
            };
        }
    }

}


