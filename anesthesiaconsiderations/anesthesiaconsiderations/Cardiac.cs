using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Cardiac : ContentPage
    {
        public Cardiac()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Cardiac";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Cardiac")
                        {
                            new TextCell
                            {
                                Text = "Adult Congenital Heart Disease",
                                Command = navigateCommand,
                                CommandParameter = typeof(AdultCongenitalHeartDisease)
                            },

                            new TextCell
                            {
                                Text = "Aortic Dissection",
                                Command = navigateCommand,
                                CommandParameter = typeof(AorticDissection)
                            },

                            new TextCell
                            {
                                Text = "Aortic Regurgitation",
                                Command = navigateCommand,
                                CommandParameter = typeof(AorticRegurgitation)
                            },

                            new TextCell
                            {
                                Text = "Aortic Stenosis",
                                Command = navigateCommand,
                                CommandParameter = typeof(AorticStenosis)
                            },
                            new TextCell
                            {
                                Text = "Atrial Fibrillation",
                                Command = navigateCommand,
                                CommandParameter = typeof(AtrialFibrilation)
                            },

                            new TextCell
                            {
                                Text = "Atrial Septal Defect",
                                Command = navigateCommand,
                                CommandParameter = typeof(AtrialSeptalDefect)
                            },

                            new TextCell
                            {
                                Text = "Brugada Syndrome",
                                Command = navigateCommand,
                                CommandParameter = typeof(BrugudaSyndrome)
                            },

                            new TextCell
                            {
                                Text = "Cardiac Contusion",
                                Command = navigateCommand,
                                CommandParameter = typeof(CardiacContusion)
                            },


                            new TextCell
                            {
                                Text = "Cardiac Tamponade",
                                Command = navigateCommand,
                                CommandParameter = typeof(CardiacTamponade)
                            },

                            new TextCell
                            {
                                Text = "Cardiomyopathies",
                                Command = navigateCommand,
                                CommandParameter = typeof(Cardiomyopathies)
                            },

                            new TextCell
                            {
                                Text = "Coronary Artery Disease",
                                Command = navigateCommand,
                                CommandParameter = typeof(CoronaryArteryDisease)
                            },

                            new TextCell
                            {
                                Text = "Fontan Physiology",
                                Command = navigateCommand,
                                CommandParameter = typeof(FontanPhysiology)
                            },

                            new TextCell
                            {
                                Text = "Hypertrophic Obstructive Cardiomyopathy",
                                Command = navigateCommand,
                                CommandParameter = typeof(HypertrophicObstructiveCardiomyopathy)
                            },

                            new TextCell
                            {
                                Text = "Infective Endocarditis Prophylaxis",
                                Command = navigateCommand,
                                CommandParameter = typeof(InfectiveEndocarditisProphylaxis)
                            },

                            new TextCell
                            {
                                Text = "Mitral Regurgitation",
                                Command = navigateCommand,
                                CommandParameter = typeof(MitralRegurgitation)
                            },

                            new TextCell
                            {
                                Text = "Mitral Stenosis",
                                Command = navigateCommand,
                                CommandParameter = typeof(MitralStenosis)
                            },

                            new TextCell
                            {
                                Text = "Pacemakers & ICDs",
                                Command = navigateCommand,
                                CommandParameter = typeof(PacemakerAndICDs)
                            },

                            new TextCell
                            {
                                Text = "Pulmonary Hypertension",
                                Command = navigateCommand,
                                CommandParameter = typeof(PulmonaryHypertension)
                            },

                            new TextCell
                            {
                                Text = "QT Prolongation",
                                Command = navigateCommand,
                                CommandParameter = typeof(QTProlongation)
                            },

                            new TextCell
                            {
                                Text = "Transplanted Heart",
                                Command = navigateCommand,
                                CommandParameter = typeof(TransplantedHeart)
                            },

                            new TextCell
                            {
                                Text = "Tricuspid Regurgitation",
                                Command = navigateCommand,
                                CommandParameter = typeof(TricuspidRegurgitation)
                            },

                            new TextCell
                            {
                                Text = "Wolff-Parkinson-White Syndrome",
                                Command = navigateCommand,
                                CommandParameter = typeof(WolffParkinsonWhiteSyndrome)
                            },

                        }
                    }
            };
        }
    }

}

