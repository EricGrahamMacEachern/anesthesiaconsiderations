using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Neuroanesthesia : ContentPage
    {
        public Neuroanesthesia()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Neuroanesthesia";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Acute Spinal Cord Injury")
                        {
                            new TextCell
                            {
                                Text = "Acute Spinal Cord Injury",
                                Command = navigateCommand,
                                CommandParameter = typeof(AcuteSpinalCordInjury)
                            },

                            new TextCell
                            {
                                Text = "Aneurism Coiling",
                                Command = navigateCommand,
                                CommandParameter = typeof(AneurismCoiling)
                            },

                            new TextCell
                            {
                                Text = "Arnold Chiari Malformation",
                                Command = navigateCommand,
                                CommandParameter = typeof(ArnoldChiariMalformation)
                            },

                            new TextCell
                            {
                                Text = "Autonomic Hyperreflexia",
                                Command = navigateCommand,
                                CommandParameter = typeof(AutonomicHyperreflexia)
                            },

                            new TextCell
                            {
                                Text = "Craniotomy",
                                Command = navigateCommand,
                                CommandParameter = typeof(Craniotomy)
                            },
                            new TextCell
                            {
                                Text = "Pituitary Surgery",
                                Command = navigateCommand,
                                CommandParameter = typeof(PituitarySurgery)
                            },

                            new TextCell
                            {
                                Text = "Posterior Fossa Surgery",
                                Command = navigateCommand,
                                CommandParameter = typeof(PosteriorFossaSurgery)
                            },

                            new TextCell
                            {
                                Text = "Spina Bifida",
                                Command = navigateCommand,
                                CommandParameter = typeof(SpinaBifida)
                            },

                            new TextCell
                            {
                                Text = "Spine Surgery",
                                Command = navigateCommand,
                                CommandParameter = typeof(SpineSurgery)
                            },

                            new TextCell
                            {
                                Text = "Subarachnoid Hemorrhage",
                                Command = navigateCommand,
                                CommandParameter = typeof(SubarachnoidHemorrhage)
                            },

                            new TextCell
                            {
                                Text = "Traumatic Brain Injury",
                                Command = navigateCommand,
                                CommandParameter = typeof(TraumaticBrainInjury)
                            },
                        }
                    }
            };
        }
    }

}

