using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Pediatrics : ContentPage
    {
        public Pediatrics()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Pediatrics";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Pediatrics")
                        {
                            new TextCell
                            {
                                Text = "Airway Foreign Body",
                                Command = navigateCommand,
                                CommandParameter = typeof(AirwayForeignBody)
                            },

                            new TextCell
                            {
                                Text = "Bronchopulmonary Dysplasia",
                                Command = navigateCommand,
                                CommandParameter = typeof(AirwayForeignBody)
                            },

                            new TextCell
                            {
                                Text = "Cerebral Palsy",
                                Command = navigateCommand,
                                CommandParameter = typeof(CerebralPalsy)
                            },

                            new TextCell
                            {
                                Text = "Cleft Lip & Palate",
                                Command = navigateCommand,
                                CommandParameter = typeof(CleftLipAndPalate)
                            },
                            new TextCell
                            {
                                Text = "Congenital Diaphragmatic Hernia",
                                Command = navigateCommand,
                                CommandParameter = typeof(CongenitalDiaphragmaticHernia)
                            },

                            new TextCell
                            {
                                Text = "Craniofacial Dysostosis",
                                Command = navigateCommand,
                                CommandParameter = typeof(CraniofacialDysostosis)
                            },

                            new TextCell
                            {
                                Text = "Croup/Laryngotracheobronchitis",
                                Command = navigateCommand,
                                CommandParameter = typeof(CroupLaryngotracheobronchitis)
                            },

                            new TextCell
                            {
                                Text = "Down Syndrome",
                                Command = navigateCommand,
                                CommandParameter = typeof(DownSyndrome)
                            },
                                  new TextCell
                            {
                                Text = "Duchenne Muscular Dystrophy",
                                Command = navigateCommand,
                                CommandParameter = typeof(DuchenneMuscularDystrophy)
                            },

                            new TextCell
                            {
                                Text = "Epiglottitis",
                                Command = navigateCommand,
                                CommandParameter = typeof(Epiglottitis)
                            },

                            new TextCell
                            {
                                Text = "Fontan Physiology",
                                Command = navigateCommand,
                                CommandParameter = typeof(FontanPhysiology)
                            },

                            new TextCell
                            {
                                Text = "Former Premature Infant",
                                Command = navigateCommand,
                                CommandParameter = typeof(FormerPrematureInfant)
                            },

                            new TextCell
                            {
                                Text = "Mucopolysaccharidosis",
                                Command = navigateCommand,
                                CommandParameter = typeof(Mucopolysaccharidosis)
                            },

                            new TextCell
                            {
                                Text = "Necrotizing Enterocolitis",
                                Command = navigateCommand,
                                CommandParameter = typeof(NecrotizingEnterocolitis)
                            },

                            new TextCell
                            {
                                Text = "Omphalocele and Gastroschisis",
                                Command = navigateCommand,
                                CommandParameter = typeof(OmphaloceleAndGastroschisis)
                            },

                            new TextCell
                            {
                                Text = "Pediatric Patient",
                                Command = navigateCommand,
                                CommandParameter = typeof(PediatricPatient)
                            },

                            new TextCell
                            {
                                Text = "Pierre Robin Syndrome",
                                Command = navigateCommand,
                                CommandParameter = typeof(PierreRobinSyndrome)
                            },

                            new TextCell
                            {
                                Text = "Premature Infant",
                                Command = navigateCommand,
                                CommandParameter = typeof(PrematureInfant)
                            },

                            new TextCell
                            {
                                Text = "Pyloric Stenosis",
                                Command = navigateCommand,
                                CommandParameter = typeof(PyloricStenosis)
                            },

                            new TextCell
                            {
                                Text = "Scoliosis",
                                Command = navigateCommand,
                                CommandParameter = typeof(Scoliosis)
                            },

                            new TextCell
                            {
                                Text = "Tetralogy of Fallot",
                                Command = navigateCommand,
                                CommandParameter = typeof(TetralogyOfFallout)
                            },

                            new TextCell
                            {
                                Text = "Tonsillectomy",
                                Command = navigateCommand,
                                CommandParameter = typeof(TetralogyOfFallout)

                            },

                            new TextCell
                            {
                                Text = "Tracheoesophageal Fistula",
                                Command = navigateCommand,
                                CommandParameter = typeof(TracheosophagealFistula)
                            },

                        }
                    }
            };
        }
    }

}


