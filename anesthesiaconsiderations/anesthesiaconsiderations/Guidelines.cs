using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Guidelines : ContentPage
    {
        public Guidelines()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Guidelines";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Guidelines")
                        {
                            new TextCell
                            {
                                Text = "Antibiotic Prophylaxis for Infective Endocarditis (IE) Guidelines ",
                                Command = navigateCommand,
                                CommandParameter = typeof(AntibioticProphylaxisforInfectiveEndocarditisIEGuidelines)
                            },

                            new TextCell
                            {
                                Text = "Canadian Diabetes Association Glycemic Control Guidelines ",
                                Command = navigateCommand,
                                CommandParameter = typeof(CanadianDiabetesAssociationGlycemicControlGuide)
                            },

                            new TextCell
                            {
                                Text = "2017 CCS Perioperative Guidelines",
                                Command = navigateCommand,
                                CommandParameter = typeof(Bronchospasm)
                            },

                            new TextCell
                            {
                                Text = "ERAS Guidelines",
                                Command = navigateCommand,
                                CommandParameter = typeof(DelayedEmergence)
                            },
                            new TextCell
                            {
                                Text = "Management of Severe Traumatic Brain Injury (TBI)",
                                Command = navigateCommand,
                                CommandParameter = typeof(ExtravasationInjuries)
                            },

                            new TextCell
                            {
                                Text = "Obstructive Sleep Apnea",
                                Command = navigateCommand,
                                CommandParameter = typeof(FatEmbolism)
                            },

                            new TextCell
                            {
                                Text = "Postoperative Nausea & Vomiting Guidelines ",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hypertension)
                            },

                            new TextCell
                            {
                                Text = "Sepsis Guidelines 2016",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hypoglycemia)
                            },

                            new TextCell
                            {
                                Text = "SOGC Hypertensive Disorders of Pregnancy 2014",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hypotension)
                            },
                        }
                    }
            };
        }
    }

}

