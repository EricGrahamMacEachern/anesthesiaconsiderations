using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Hyperaldosteronism : ContentPage
    {
        public Hyperaldosteronism()
        {
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            BackgroundColor = Color.White;

            Label header = new Label
            {
                Text = "Hyperaldosteronism",
                TextColor = Color.Black,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center,
            };
            ScrollView scrollView = new ScrollView
            {
                Margin = 0,
                Padding = 0,
                Content = new StackLayout
                {
                    Spacing = 0,
                    Padding = 0,
                    //Orientation = StackOrientation.Vertical,
                    Children =
                    {
                        new StackLayout
                        {
                            Padding = 0,
                            Children =
                            {
                                new Label
                                {
                                    FontSize = 20,
                                    Text = "Considerations",
                                    TextColor = Color.Black,
                                    FontAttributes = FontAttributes.Bold,
                                },
                                new Label
                                {
                                    Text = " ",
                                    FontSize = 5,
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Hypertension & end-organ dysfunction:",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },


                      new StackLayout
                        {
                            Padding = new Thickness(20, 0, 0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "​Cardiomyopathy ",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                      new StackLayout
                        {
                            Padding = new Thickness(20, 0, 0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "​Cerebrovascular disease",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                      new StackLayout
                        {
                            Padding = new Thickness(20, 0, 0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "​Chronic kidney disease ",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Fluid & electrolyte abnormalities:",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                      new StackLayout
                        {
                            Padding = new Thickness(20, 0, 0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Hypokalemia (weakness, potentiates non-depolarizing muscle relaxants)",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                      new StackLayout
                        {
                            Padding = new Thickness(20, 0, 0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Metabolic alkalosis",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                      new StackLayout
                        {
                            Padding = new Thickness(20, 0, 0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Volume depletion",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                      new StackLayout
                        {
                            Padding = new Thickness(20, 0, 0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Hypomagnesemia",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Associated endocrine disorders:",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                      new StackLayout
                        {
                            Padding = new Thickness(20, 0, 0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Acromegaly",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                      new StackLayout
                        {
                            Padding = new Thickness(20, 0, 0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Pheochromocytoma",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                      new StackLayout
                        {
                            Padding = new Thickness(20, 0, 0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Primary hyperparathyroidism",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                      new StackLayout
                        {
                            Padding = new Thickness(20, 0, 0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Medications such as spironolactone ",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Adrenalectomy:",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                      new StackLayout
                        {
                            Padding = new Thickness(20, 0, 0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Bilateral? Need steroids",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                      new StackLayout
                        {
                            Padding = new Thickness(20, 0, 0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Laparascopic vs. open (pain & disposition)\n\n",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = 0,
                            Children =
                            {
                                new Label
                                {
                                    FontSize = 20,
                                    Text = "Optimization",
                                    TextColor = Color.Black,
                                    FontAttributes = FontAttributes.Bold,
                                },
                                new Label
                                {
                                    Text = " ",
                                    FontSize = 5,
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Antihypertensive therapy",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "• ",
                                    TextColor = Color.Black,
                                },
                                new Label
                                {
                                    FontSize = 16,
                                    Text = "Correction of electrolyte abnormalities",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },



        }
                }
            };

            Button homeButton = new Button
            {
                Text = "Home Page",
                Command = navigateCommand,
                CommandParameter = typeof(HomePage),
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };


            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    scrollView,
                    homeButton,
                }
            };
        }
    }
}