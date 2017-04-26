using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AorticDissection : ContentPage
    {
        public AorticDissection()
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
                Text = "Aortic Dissection",
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
                                    Text =
                                        "Type & urgency:",
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
                                        "Stanford type A: Surgical management",
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
                                        "Stanford type B: Medical management or stent only if organ damage or complicated aortic dissection",
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
                                        "End organ damage & ischemia",
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
                                        "Acute renal failure",
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
                                        "Stanford type A associated with aortic insufficiency, tamponade, MI, CVA",
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
                                        "Spinal cord ischemia",
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
                                        "Ischemic gut",
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
                                        "Limb ischemia",
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
                                        "Hemorrhagic shock ",
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
                                        "Pleural effusions",
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
                                        "Retroperitoneal bleeding ",
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
                                        "Underlying cause of aortic dissection",
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
                                        "Trauma ",
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
                                        "Hypertension, atherosclerosis",
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
                                        "Cocaine/amphetamine use",
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
                                        "Pregnancy",
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
                                        "Collagen vascular disease (e.g. Marfan's)\n\n",
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
                                    Text = "Anesthetic Management ",
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
                                        "Medical stabilization:",
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
                                        "IV access, CVC, arterial line (R arm AND L arm or femoral)",
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
                                        "​Hemodynamic goals ",
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
                                        "​Preload: maintain adequate preload; aggressive fluid therapy may worsen dissection ",
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
                                        "Intervention (surgical or radiologic) of the primary condition is often needed ",
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
                                        "Rate: heart rate <60bpm with beta blockade",
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
                                        "Rhythm: maintain normal sinus rhythm",
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
                                        "Contractility: reduce contractility with beta blockade to reduce sheer stress on intima ",
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
                                        "Afterload: reduce sBP to a target of 100-120 mmHg to reduce sheer stress on intima ",
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
                                        "Main goal is to ↓ cardiac contractility & BP to ↓ intimal stress",
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
                                        "1st line therapy is beta blockade to achieve hemodynamic goals",
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
                                        "Afterload: reduce sBP to a target of 100-120 mmHg to reduce sheer stress on intima ",
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
                                        "Labetalol (bolus 20-80mg then infusion 0.5-2mg/min) ",
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
                                        "Afterload: reduce sBP to a target of 100-120 mmHg to reduce sheer stress on intima ",
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
                                        "Esmolol (bolus 0.5-1 mg/kg then infusion 50-200 mcg/kg/min)",
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
                                        "Consider diltiazem (2.5-5mg IV q15min) & verapamil (2.5-5mg IV q15min) in patients intolerant of beta blockers",
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
                                        "Consider adding sodium nitroprusside (0.25-0.5mcg/kg/min) to achieve sBP of 100-120mmHg",
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
                                    Text ="Adequate pain control",
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
                                        "Main goal is to ↓ cardiac contractility & BP to ↓ intimal stress",
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
                                        "Inotropes",
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
                                        "Hydralazine, which can cause aortic wall sheer stress",
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
                                        "Vasodilation before beta blockade, which can cause reflex sympathetic activation",
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
                                        "Pericardiocentesis in tamponade, which can cause exsanguination\n\n",
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
                                    Text =
                                        "Aggressive alpha & beta-blockade to ↓ dP/dT as above",
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
                                        "Continuous fetal heart rate monitoring (marker of end organ perfusion)",
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
                                        "Type B:",
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
                                        "Medical management & expedite delivery",
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
                                        "Use short acting agents (esmolol, labetalol, phentolamine)",
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
                                        "Conflicts: ",
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
                                    Text ="Antihypertensives vs. bleeding risk/post partum hemorrhage (eg. nitroglycerine & ↓ uterine tone)",
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
                                    Text ="Avoid fetal toxic medications (sodium nitroprusside)",
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
                                    Text ="Avoid ergotamine for post partum hemorrhage",
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
                                        "Type A:",
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
                                        "If diagnosed <28 weeks = surgical repair, then allow pregnancy to continue",
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
                                        "28-32 weeks = surgical repair, cesarean section if obstetrical indications",
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
                                        ">32 weeks = simultaneous repair & cesarean section",
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