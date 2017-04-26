using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Neuromuscular : ContentPage
    {
        public Neuromuscular()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Neuromuscular";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Neuromuscular")
                        {
                            new TextCell
                            {
                                Text = "Amyotrophic Lateral Sclerosis (ALS)",
                                Command = navigateCommand,
                                CommandParameter = typeof(AmyotrophicLateralSclerosisALS)
                            },

                            new TextCell
                            {
                                Text = "Guillain-Barre Syndrome (GBS)",
                                Command = navigateCommand,
                                CommandParameter = typeof(GuillainBarreSyndromeGBS)
                            },

                            new TextCell
                            {
                                Text = "Multiple Sclerosis",
                                Command = navigateCommand,
                                CommandParameter = typeof(MultipleSclerosis)
                            },

                            new TextCell
                            {
                                Text = "Myasthenia Gravis",
                                Command = navigateCommand,
                                CommandParameter = typeof(MyastheniaGravis)
                            },
                            new TextCell
                            {
                                Text = "Myasthenic (Eaton-Lambert) Syndrome",
                                Command = navigateCommand,
                                CommandParameter = typeof(MyasthenicEatonLambertSyndrome)
                            },

                            new TextCell
                            {
                                Text = "Myotonic Dystrophy",
                                Command = navigateCommand,
                                CommandParameter = typeof(MyotonicDystrophy)
                            },

                            new TextCell
                            {
                                Text = "Parkinsons Disease",
                                Command = navigateCommand,
                                CommandParameter = typeof(ParkinsonsDisease)
                            },

                            new TextCell
                            {
                                Text = "Polymyositis & Dermatomyositis",
                                Command = navigateCommand,
                                CommandParameter = typeof(PolymyositisAndDermatomyositis)
                            },

                        }
                    }
            };
        }
    }

}

