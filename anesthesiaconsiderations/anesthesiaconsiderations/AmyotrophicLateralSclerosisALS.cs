using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AmyotrophicLateralSclerosisALS : ContentPage
    {
        public AmyotrophicLateralSclerosisALS()
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
                Text = "Amytrophic Lateral Sclerosis ALS",
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
                            //Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    FontSize = 20,
                                    Text = "Background",
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
                                    Text =
                                        "Progressive degenerative disease of upper & lower motor neurons leading to denervation & atrophy of skeletal muscle with resultant weakness & eventual death\n\n",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },
                        new StackLayout
                        {
                            Padding = 0,
                            //Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    FontSize = 20,
                                    Text = "Considerations ",
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
                                    Text =
                                        "Aspiration risk due to bulbar dysfunction",
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
                                    Text =
                                        "Perioperative respiratory failure due to weakness & aspiration ",
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
                                    Text = "Autonomic dysfunction",
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
                                    Text = "Altered response to neuromuscular blockers:",
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
                                    Text =
                                        "Succinylcholine contraindicated due to hyperkalemia risk",
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
                                    Text =
                                        "NdMR (nondepolarizing muscle relaxant) sensitivity",
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
                                    Text = "Chronic pain (often girdle area)\n\n",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },
                        new StackLayout
                        {
                            Padding = 0,
                            //Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    FontSize = 20,
                                    Text = "Goals ",
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
                                    Text = "Minimize aspiration risk (prophylaxis, consider RSI)",
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
                                    Text = "Maximize respiratory function (muscle strength, secretion & pain management)",
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
                                    Text = "Anticipate potential need for postop ventilation/ICU",
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
                                    Text = "Maintain stable hemodynamics\n\n",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },
                        new StackLayout
                        {
                            Padding = 0,
                            //Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    FontSize = 20,
                                    Text = "Conflicts ",
                                    TextColor = Color.Black,
                                    FontAttributes = FontAttributes.Bold
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
                                    Text = "RSI vs. avoid succinylcholine/sensitive to NdMRs",
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
                                    Text = "RSI vs. maintain hemodynamic stability",
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
                                    Text = "Regional vs. existing neurologic deficits:",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },
                        new StackLayout
                        {
                            Padding = new Thickness(40, 0, 0, 0),
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
                                    Text =
                                        "Epidural documented in case reports but be cautious of high block ",
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
                                    Text =
                                        "Peripheral nerve blocks not documented because disease so rare but definitely a consideration given respiratory muscle weakness",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = new Thickness(40, 0, 0, 0),
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
                                    Text =
                                        "Avoid interscalene so as to not compromise phrenic nerve",
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
                                    Text =
                                        "General anesthetic vs. respiratory depression (neuraxial is safe)",
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