using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Legal : ContentPage
    {
        public Legal()
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
                Text = "Legal",
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
                                    Text = "Terms of Use",
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
                                    FontSize = 16,
                                    Text = "Anesthesiaconsiderations.com & anesthesiaconsiderations.ca provide their content to you subject to the following terms of use. When you use these websites, you agree to be bound by these terms of use.  Please read these terms of use carefully. If you do not agree with these Terms of Use, please do not use these websites.",
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
                                    Text = "Copyright/Licensing ",
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
                                    FontSize = 16,
                                    Text = "Anesthesiaconsiderations.com and anesthesiaconsiderations.ca, including the text, graphics, and software that appear on these websites, is owned by or licensed to these websites and its owners, and is subject to copyright and other intellectual property rights under United States, Canadian, foreign laws and international conventions.",
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
                                    FontSize = 16,
                                    Text = "Users may not re-post  content from these websites on other web sites without the permission of these websites. User cannot re-sell the contents on these websites to third parties, or prepare derivative works of the content of these websites. ",
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
                                    Text = "Consumer Content",
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
                                    FontSize = 16,
                                    Text = "These websites are designed to offer users general health information for educational purposes only. The general health information furnished on these sites is not intended to replace personal consultation with a qualified health care professional. You must always seek the advice of a professional for questions related to your disease, disease symptoms, and appropriate therapeutic treatments. If you have or suspect that you have a medical problem or condition, please contact a qualified health care professional immediately. You should never disregard medical advice or delay in seeking it because of something you have read on this site. IF YOU HAVE AN EMERGENCY, CALL 9-1-1.",
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
                                    FontSize = 16,
                                    Text = "Thse websites does not give medical advice, nor do we provide medical or diagnostic services. Neither these websites or any of its affiliates or employees guarantee that the content covers all possible uses, direction, precautions, drug interactions, or adverse effects that may be associated with any therapeutic treatments. You may not rely on the application of any information on this website as being applicable to your specific circumstances. Neither these websites or any of its affiliates assume any liability or responsibility for damages or injury to you, other persons, or property arising from any use of any information, idea, or instruction contained in these websites.\n\n ",
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
                                    Text = "No Unlawful Use",
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
                                    FontSize = 16,
                                    Text = "You agree not to use these websites (anesthesiaconsiderations.com & anesthesiaconsiderations.ca) for any purpose that is unlawful or prohibited by these terms, or the terms of a subscriber agreement you have with these websites, if applicable. You may not use these websites in any manner that could damage, disable, overburden, or impair these websites' server(s), or the network(s) connected to any of these websites' servers, or interfere with any other party's use and enjoyment of these websites. You may not attempt to gain unauthorized access to any portion of these websites, other accounts, computer systems, or networks connected to these websites' servers, through hacking, password or data mining, or any other means. You may not obtain or attempt to obtain any materials or information through any means not intentionally made available to you on these websites.\n\n",
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
                                    Text = "No Warranties",
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
                                    FontSize = 16,
                                    Text = "NEITHER THESE WEBSITES, NOR ANY PARENT, SUBSIDIARY, AFFILIATE, DIRECTOR, EMPLOYEE, LICENSOR, LICENSEE, DISTRIBUTOR, SUPPLIER, AGENT, OR RESELLER OF THESE WEBSITES MAKE ANY WARRANTY OR REPRESENTATION, EXPRESSED OR IMPLIED, WITH RESPECT TO THESE WEBSITES' SERVICES, WHICH ARE PROVIDED 'AS IS', OR WITH RESPECT TO THESE TERMS OF USE. THESE WEBSITES' ENTITIES EXPRESSLY EXCLUDE AND DISCLAIM ALL WARRANTIES, INCLUDING, WITHOUT LIMITATION, IMPLIED WARRANTIES OF MERCHANTABILITY OR FITNESS FOR A PARTICULAR PURPOSE, AND ANY WARRANTIES ARISING BY STATUTE OR OTHERWISE IN LAW OR FROM COURSE OF DEALING, COURSE OF PERFORMANCE, OR USE OF TRADE. ANY STATEMENTS OR REPRESENTATIONS MADE BY ANY OTHER PERSON OR ENTITY ARE VOID. YOU ASSUME ALL RISK AS TO THE QUALITY, FUNCTION, AND PERFORMANCE OF THESE WEBSITES.",
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
                                    FontSize = 16,
                                    Text = "Some states or other jurisdictions do not allow the exclusion of implied warranties, so the above exclusions may not apply to you.",
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
                                    FontSize = 16,
                                    Text = "In addition, please note that this website may include technical inaccuracies or typographical errors.  These websites have the right at any time to change, modify, add to, discontinue, or retire any aspect or feature of these websites, including, but not limited to, hours of availability, equipment needed for access or use, or the availability of these websites' services on any particular device or communications service. These websites have no obligation to provide you with notice of any such changes, and these websites are under no obligation to provide you with any support, error corrections, updates, upgrades, bug fixes, and/or enhancements of these websites, except as provided by your subscriber agreement with these websites, if applicable.\n\n",
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
                                    Text = "Limitation of Liability ",
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
                                    FontSize = 16,
                                    Text = "IN NO EVENT WILL THESE WEBSITES OR ANY OTHER PARTY WHO HAS BEEN INVOLVED IN THE CREATION, PRODUCTION, DISTRIBUTION, PROMOTION, OR MARKETING OF THESE WEBSITES OR THESE TERMS OF USE BE LIABLE TO YOU OR ANY OTHER PARTY FOR ANY SPECIAL, INDIRECT, INCIDENTAL, RELIANCE, EXEMPLARY, OR CONSEQUENTIAL DAMAGES, INCLUDING, WITHOUT LIMITATION, LOSS OF DATA OR PROFITS, OR FOR INABILITY TO USE THESE WEBSITES, EVEN IF THESE WEBSITES OR SUCH OTHER PARTY HAVE BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES. SUCH LIMITATION SHALL APPLY NOTWITHSTANDING ANY FAILURE OF ESSENTIAL PURPOSE OF ANY LIMITED REMEDY AND TO THE FULLEST EXTENT PERMITTED BY LAW.",
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
                                    FontSize = 16,
                                    Text = "Some states or other jurisdictions do not allow limitations on how long an implied warranty lasts and some jurisdictions do not allow the exclusion or limitation of special, indirect, incidental, exemplary, or consequential damages, or the limitation of liability to specified amounts, so the above limitation and exclusion may not apply to you if prohibited by applicable law.\n\n",
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
                                    Text = "Indemnification ",
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
                                    FontSize = 16,
                                    Text = "You agree to defend, indemnify, and hold harmless these websites and all its affiliates from all liabilities, claims, and expenses, including attorneys' fees, that arise from your use of these websites.  These websites reserve the right, at their own expense, to assume the exclusive defense and control of any matter otherwise subject to indemnification by you, in which event you will cooperate with these websites in asserting any available defenses.\n\n",
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
                                    Text = "Modifications ",
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
                                    FontSize = 16,
                                    Text = "These websites may modify these terms of use from time to time and changes will be effective upon posting to these websites. You agree to be bound by any modification of these terms of use when you use these websites, effective after their posting to these websites. It is therefore important that you review these terms of use regularly to ensure you are updated as to any changes.",
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