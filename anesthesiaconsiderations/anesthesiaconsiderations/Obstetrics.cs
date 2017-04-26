using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Obstetrics : ContentPage
    {
        public Obstetrics()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Obstetrics";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Obstetrics")
                        {
                            new TextCell
                            {
                                Text = "Amniotic Fluid Embolism",
                                Command = navigateCommand,
                                CommandParameter = typeof(AmnioticFluidEmbolism)
                            },

                            new TextCell
                            {
                                Text = "Antepartum Hemorrhage",
                                Command = navigateCommand,
                                CommandParameter = typeof(AntepartumHemorrhage)
                            },

                            new TextCell
                            {
                                Text = "Breech Presentation",
                                Command = navigateCommand,
                                CommandParameter = typeof(BreechPresentation)
                            },

                            new TextCell
                            {
                                Text = "Cervical Cerclage",
                                Command = navigateCommand,
                                CommandParameter = typeof(CervicalCerclage)
                            },

                            new TextCell
                            {
                                Text = "Dyspnea in Pregnancy",
                                Command = navigateCommand,
                                CommandParameter = typeof(DyspnealnPregnancy)
                            },
                            new TextCell
                            {
                                Text = "External Cephalic Version ",
                                Command = navigateCommand,
                                CommandParameter = typeof(ExternalCephalicVersion)
                            },

                            new TextCell
                            {
                                Text = "Fetal Distress",
                                Command = navigateCommand,
                                CommandParameter = typeof(FetalDistress)
                            },

                            new TextCell
                            {
                                Text = "Multiple Gestation",
                                Command = navigateCommand,
                                CommandParameter = typeof(MultipleGestation)
                            },

                            new TextCell
                            {
                                Text = "Non Obstetrical Surgery in Pregnancy",
                                Command = navigateCommand,
                                CommandParameter = typeof(NonObstetricalSurgeryInPregnancy)
                            },
                                  new TextCell
                            {
                                Text = "Peripartum Cardiac Arrest",
                                Command = navigateCommand,
                                CommandParameter = typeof(PeripartumCardiacArrest)
                            },

                            new TextCell
                            {
                                Text = "Peripartum Cardiomyopathy",
                                Command = navigateCommand,
                                CommandParameter = typeof(PeripartumCardiomyopathy)
                            },

                            new TextCell
                            {
                                Text = "Placental Abruption",
                                Command = navigateCommand,
                                CommandParameter = typeof(PlacentalAbruption)
                            },

                            new TextCell
                            {
                                Text = "Postpartum Hemorrhage",
                                Command = navigateCommand,
                                CommandParameter = typeof(PostpartumHemorrhage)
                            },

                            new TextCell
                            {
                                Text = "Preeclampsia",
                                Command = navigateCommand,
                                CommandParameter = typeof(Preeclampsia)
                            },

                            new TextCell
                            {
                                Text = "Uterine Inversion",
                                Command = navigateCommand,
                                CommandParameter = typeof(UterineInversion)
                            },

                        }
                    }
            };
        }
    }

}


