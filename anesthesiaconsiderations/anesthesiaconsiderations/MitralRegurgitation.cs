using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class MitralRegurgitation : ContentPage
    {
        public MitralRegurgitation()
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
                Text = "Mitral Regurgitation",
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
                                    Text = "↑ risk of perioperative cardiac complications (MI/CHF)",
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
                                    Text = "Hemodynamic alterations associated with MR:",
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
                                    Text = "Left atrial volume overload & ↓ forward cardiac output (CO)",
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
                                    Text = "Potential for LV dysfunction (from overload)",
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
                                    Text = "Potential for arrhythmias (atrial fibrillation commonly) due to LA dilatation",
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
                                    Text = "Potential for pulmonary hypertension leading to RV dysfunction",
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
                                    Text = "Acute MR: sudden LA & LV overload without compensatory hypertrophy leading to decreased forward CO & simultaneous pulmonary congestion",
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
                                    Text = "Comorbid disease:",
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
                                    Text = "Coronary artery disease",
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
                                    Text = "Atrial fibrillation",
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
                                    Text = "Other valvular lesions (MS, AI)",
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
                                    Text = "Connective tissue diseases (SLE, RA, Marfan’s)",
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
                                    Text = "Endocarditis",
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
                                    Text = "Management of medical therapy:",
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
                                    Text = "ACE inhibitors, beta-blockers, digoxin, calcium channel blockers\n\n",
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
                                    Text = "Goals",
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
                                    Text = "Maintain forward flow & ↓ regurgitant fraction:",
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
                                    Text = "Preload: maintain preload but avoid overload (↑ risk for CHF)",
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
                                    Text = "Rate: high-normal rate (80-100bpm) & avoid bradycardia (longer diastole = more regurgitation)",
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
                                    Text = "Rhythm: sinus rhythm preferred but not as critical as stenotic lesions ",
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
                                    Text = "Contractility: maintain or enhance contractility to improve forward flow & reduce regurgitant fraction by constricting mitral valve annulus",
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
                                    Text = "Afterload: reduce afterload to enhance forward flow ",
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
                                    Text = "Avoid ↑ in pulmonary vascular resistance to mitigate right heart failure (avoid hypoxia, hypercarbia, acidosis, pain)\n\n",
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
                                    Text = "Pregnancy Considerations ",
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
                                    Text = "Goals:",
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
                                    Text = "Prevent an ↑ in SVR",
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
                                    Text = "Maintain a normal to slightly elevated heart rate",
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
                                    Text = "Maintain sinus rhythm",
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
                                    Text = "Aggressively treat acute atrial fibrillation",
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
                                    Text = "Avoid aortocaval compression",
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
                                    Text = "Maintain venous return",
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
                                    Text = "Prevent an ↑ in central vascular volume",
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
                                    Text = "Avoid myocardial depression during general anesthesia",
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
                                    Text = "Prevent pain, hypoxemia, hypercarbia, & acidosis (may ↑ PVR)",
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
                                    Text = "Monitoring:",
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
                                    Text = "Invasive monitoring rarely required unless severe mitral regurgitation ",
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
                                    Text = "Anesthetic options:",
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
                                    Text = "Epidural preferred for vaginal delivery or cesarean section ",
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
                                    Text = "If GA used, give attention to the maintenance of adequate heart rate & ↓ afterload",
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
                                    Text = "Acute atrial fibrillation must be treated promptly & aggressively; hemodynamic instability warrants the immediate performance of cardioversion",
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