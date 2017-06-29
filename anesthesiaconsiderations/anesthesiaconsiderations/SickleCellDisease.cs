using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class SickleCellDisease : ContentPage
    {
        public SickleCellDisease()
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
                Text = "Sickle Cell Disease",
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
                                    Text = "Multisystem disease with end-organ dysfunction:",
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
                                    Text = "​CNS: stroke",
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
                                    Text = "​Cardiovascular: LV hypertrophy, high-output cardiac failure (anemia), myocardial infarction without coronary artery disease ",
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
                                    Text = "​Respiratory: acute chest syndrome (ACS), restrictive lung disease (pulmonary fibrosis), pulmonary hypertension, RV hypertrophy, cor-pulmonale",
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
                                    Text = "Renal: renal failure, renal infarction ",
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
                                    Text = "Spleen: sequestration, infarcts; if splenectomy → ↓ immunity",
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
                                    Text = "Potential for perioperative exacerbations of vaso-occlusive crises:",
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
                                    Text = "Acute pain crisis",
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
                                    Text = "Acute chest syndrome",
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
                                    Text = "Chronic hemolytic anemia:",
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
                                    Text = "Chronic RBC transfusion & its complications (alloimmunization, iron overload, viral transmission)",
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
                                    Text = "Chronic pain & potential opioid tolerance",
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
                                    Text = "Preoperative optimization: consider preoperative transfusion for goal hematocrit: 30%, hemoglobin: 100 (see discussion in optimization)",
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
                                    Text = "Medications: immunosuppresants, antineoplastics\n\n",
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
                                    Text = "Avoid precipitants of sickle cell crisis:",
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
                                    Text = "​Hypoxia",
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
                                    Text = "Vascular stasis",
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
                                    Text = "Hypothermia",
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
                                    Text = "Hypovolemia/hypotension",
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
                                    Text = "Acidosis",
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
                                    Text = "Optimize perioperative pain control ",
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
                                    Text = "Monitor for:",
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
                                    Text = "Vaso-occlusive crisis",
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
                                    Text = "Acute chest syndrome",
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
                                    Text = "Aplastic crisis",
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
                                    Text = "Splenic sequestration syndrome",
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
                                    Text = "Right upper quadrant syndrome\n\n",
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
                                    Text = "Optimization (in consultation with hematology)",
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
                                    Text = "Risk factors for acute pain crises:",
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
                                    Text = "Age, frequency of hospitalizations &/or transfusions for episodes of crisis, evidence of organ damage (e.g., low baseline oxygen saturation, elevated creatinine, cardiac dysfunction), history of central nervous system events, concurrent infection",
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
                                    Text = "Procedural risk for complications:",
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
                                    Text = "Low: minor surgery (e.g., inguinal hernia & extremity surgery)",
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
                                    Text = "Intermediate: intra-abdominal operations (e.g., cholecystectomy)",
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
                                    Text = "High: intracranial & intrathoracic procedures, hip surgery",
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
                                    Text = "Hematology consult, optimize treatment:",
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
                                    Text = "Hydroxyurea to ↑ fetal hemoglobin production",
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
                                    Text = "Cancel non-emergent cases if patient experiencing a crisis",
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
                                    Text = "Only low risk patients should be considered for outpatient surgery",
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
                                    Text = "IV fluid to avoid dehydration while NPO",
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
                                    Text = "Preoperative transfusion therapy:",
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
                                    Text = "Controversial without good evidence",
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
                                    Text = "Purpose is to correct pre-existing anemia, ↓ hemoglobin S concentration & ↑ adult hemoglobin",
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
                                    Text = "Consider target hemoglobin 100 or hematocrit 30% for intermediate & high risk surgeries & always have blood available for any surgery",
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
                                    Text = "Exchange transfusions are not routinely recommended\n\n",
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
                                    Text = "Acute chest syndrome (ACS)",
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
                                    Text = "Background:",
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
                                    Text = "Second most common reason for hospitalization after vaso-occlusive crisis",
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
                                    Text = "Mortality 2-12%; accounts for 25% of deaths in sickle cell patients",
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
                                    Text = "Characterized by acute respiratory symptoms concurrent with new infiltrate on CXR",
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
                                    Text = "Spectrum of pathology:",
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
                                    Text = "Infection",
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
                                    Text = "Infarction (especially ribs)",
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
                                    Text = "Pulmonary sequestration",
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
                                    Text = "Fat embolism",
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
                                    Text = "Pulmonary vaso-occlusion due to sequestration of sickled cells in small pulmonary vessels",
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
                                    Text = "Infection or fat emboli may lead to vaso-occlusion & sequestration",
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
                                    Text = "Clinical picture: fever, tachypnea, pleuritic pain & cough ",
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
                                    Text = "CXR: normal to complete opacification but usually demonstrates a new lobar infiltrate:",
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
                                    Text = "Children: upper lobe disease common",
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
                                    Text = "Adults: multilobe & lower lobe disease more common",
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
                                    Text = "Strong relationship between ACS & stroke",
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
                                    Text = "Treatment:",
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
                                    Text = "​​Admit to monitored setting, may need ICU",
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
                                    Text = "Hydration to euvolemia",
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
                                    Text = "Oxygen, noninvasive PPV if necessary",
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
                                    Text = "Bronchodilators (even if not wheezing) ",
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
                                    Text = "Broad spectrum antibiotics: infection is one of the most common causes of ACS ",
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
                                    Text = "Transfusion: both simple & exchange transfusion:",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = new Thickness(60, 0, 0, 0),
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
                                    Text = "Simple transfusion: goal is to ↑ hematocrit to > 30%:",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = new Thickness(80, 0, 0, 0),
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
                                    Text = "Indications:",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = new Thickness(100, 0, 0, 0),
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
                                    Text = "To improve oxygenation, particularly in patients with oxygen saturation below 92% on room air & to prevent progression to respiratory failure",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = new Thickness(100, 0, 0, 0),
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
                                    Text = "For accentuated anemia, defined as a hematocrit that is 10% to 20% below the patient's usual hematocrit, or with a dropping hematocrit during hospitalization",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = new Thickness(100, 0, 0, 0),
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
                                    Text = "Clinical or radiological progression of disease but not impending respiratory failure",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = new Thickness(100, 0, 0, 0),
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
                                    Text = "For patients in whom exchange transfusion will be delayed; simple transfusions may be used to temporize the clinical situation until the exchange transfusion can be performed",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = new Thickness(60, 0, 0, 0),
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
                                    Text = "Exchange transfusion: goal is to ↓  the level of hemoglobin S to < 30%:  ",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = new Thickness(80, 0, 0, 0),
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
                                    Text = "Indications:",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },


                        new StackLayout
                        {
                            Padding = new Thickness(100, 0, 0, 0),
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
                                    Text = "Progression of ACS despite simple transfusion",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },


                        new StackLayout
                        {
                            Padding = new Thickness(100, 0, 0, 0),
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
                                    Text = "Severe hypoxemia",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },


                        new StackLayout
                        {
                            Padding = new Thickness(100, 0, 0, 0),
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
                                    Text = "Multi-lobar disease",
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.Start
                                },
                            }
                        },

                        new StackLayout
                        {
                            Padding = new Thickness(100, 0, 0, 0),
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
                                    Text = "Previous history of severe ACS or cardiopulmonary disease",
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
                                    Text = "Analgesia: adequate analgesia of spine, thoracic, & abdominal pain is important to prevent hypoventilation & atelectasis",
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
                                    Text = "Possibly inhaled nitric oxide for severe cases\n\n",
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
                                    Text = "Acute pain crisis (Vaso-occlusive crisis)",
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
                                    Text = "Anesthesia may be requested to assist with analgesia (e.g., patient-controlled analgesia)",
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
                                    Text = "Typically occurs in long bones, ribs, spine, or abdomen",
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
                                    Text = "Precipitants: infection, dehydration, hypothermia, hypoxia, stress, alcohol intake, menstruation",
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
                                    Text = "Bone pain from ischemia & infarction of marrow or cortex",
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
                                    Text = "Abdominal pain from bowel ischemia, organ infarction, or referred from the ribs",
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
                                    Text = "Severity of pain can range from annoying to disabling ",
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
                                    Text = "Treatment: rest, warmth, reassurance, analgesia, fluid replacement:",
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
                                    Text = "Oral analgesics may be sufficient for minor attacks",
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
                                    Text = "Opioids (IM, SC, IV, PO):",
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
                                    Text = "PCA opioids with baseline analgesia provided by background infusion or fentanyl patch",
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
                                    Text = "Acetaminophen & NSAIDs:",
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
                                    Text = "NSAIDS particularly good for bone pain",
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
                                    Text = "Ketamine as adjunct",
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
                                    Text = "Regional blocks as appropriate, epidural use has been reported\n\n",
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
                                    Text = "Interaction with pregnancy:",
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
                                    Text = "Pregnancy typically exacerbates the complications of sickle cell anemia",
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
                                    Text = "Maternal mortality is as high as 1%",
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
                                    Text = "Pulmonary embolism & infection are the leading causes of death",
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
                                    Text = "Management:",
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
                                    Text = "Hemoglobin goals:",
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
                                    Text = "> 80 for vaginal delivery ",
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
                                    Text = "> 100 for cesarean delivery",
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
                                    Text = "Epidural strongly recommended in labor to reduce stress/pain",
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
                                    Text = "Safe to use either GA or neuraxial for cesarean section",
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
                                    Text = "Goals: avoid hypovolemia, hypoxemia, hypercarbia, hypothermia, pain, stress",
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