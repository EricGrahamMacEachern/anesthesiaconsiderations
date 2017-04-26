using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Endocrinology : ContentPage
    {
        public Endocrinology()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Endocrinology";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Endocrinology")
                        {
                            new TextCell
                            {
                                Text = "Acromegaly",
                                Command = navigateCommand,
                                CommandParameter = typeof(Acromegaly)
                            },

                            new TextCell
                            {
                                Text = "Adrenocortical Insufficiency",
                                Command = navigateCommand,
                                CommandParameter = typeof(AdrenocorticalInsufficiency)
                            },

                            new TextCell
                            {
                                Text = "Alcoholism",
                                Command = navigateCommand,
                                CommandParameter = typeof(Alcoholism)
                            },

                            new TextCell
                            {
                                Text = "Anorexia Nervosa",
                                Command = navigateCommand,
                                CommandParameter = typeof(AnorexiaNervosa)
                            },
                            new TextCell
                            {
                                Text = "Carcinoid",
                                Command = navigateCommand,
                                CommandParameter = typeof(Carcinoid)
                            },

                            new TextCell
                            {
                                Text = "Cushing's Syndrome",
                                Command = navigateCommand,
                                CommandParameter = typeof(CushingsSyndrome)
                            },

                            new TextCell
                            {
                                Text = "Diabetes Insipidus",
                                Command = navigateCommand,
                                CommandParameter = typeof(DiabetesInsipidus)
                            },

                            new TextCell
                            {
                                Text = "Diabetes Mellitus",
                                Command = navigateCommand,
                                CommandParameter = typeof(DiabetesMellitus)
                            },

                            new TextCell
                            {
                                Text = "Obesity",
                                Command = navigateCommand,
                                CommandParameter = typeof(Obesity)
                            },


                            new TextCell
                            {
                                Text = "Diabetic Ketoacidosis",
                                Command = navigateCommand,
                                CommandParameter = typeof(DiabeticKetoacidosis)
                            },


                            new TextCell
                            {
                                Text = "Hyperaldosteronism",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hyperaldosteronism)
                            },


                            new TextCell
                            {
                                Text = "Hyperkalemia",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hyperkalemia)
                            },


                            new TextCell
                            {
                                Text = "Hyponatremia",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hyponatremia)
                            },

                            new TextCell
                            {
                                Text = "Hyperparathyroidism",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hyperparathyroidism)
                            },


                            new TextCell
                            {
                                Text = "Hyperthyroidism/Thyroid Storm",
                                Command = navigateCommand,
                                CommandParameter = typeof(HyperthyroidismThyroidStorm)
                            },


                            new TextCell
                            {
                                Text = "Hypothyroidism",
                                Command = navigateCommand,
                                CommandParameter = typeof(Hypothyroidism)
                            },

                            new TextCell
                            {
                                Text = "Perioperative Steroids",
                                Command = navigateCommand,
                                CommandParameter = typeof(PerioperativeSteroids)
                            },


                            new TextCell
                            {
                                Text = "Pheochromocytoma",
                                Command = navigateCommand,
                                CommandParameter = typeof(Pheochromocytoma)
                            },

                            new TextCell
                            {
                                Text = "Porphyria",
                                Command = navigateCommand,
                                CommandParameter = typeof(Porphyria)
                            },

                            new TextCell
                            {
                                Text = "SIADH",
                                Command = navigateCommand,
                                CommandParameter = typeof(SIADH)
                            },

                        }
                    }
            };
        }
    }

}
