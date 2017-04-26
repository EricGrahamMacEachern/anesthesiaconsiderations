using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class SkinAndMusculoskeletal : ContentPage
    {
        public SkinAndMusculoskeletal()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Skin & Musculoskeletal";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Skin & Musculoskeletal")
                        {
                            new TextCell
                            {
                                Text = "Achondroplasia",
                                Command = navigateCommand,
                                CommandParameter = typeof(Achondroplasia)
                            },

                            new TextCell
                            {
                                Text = "Ankylosing Spondylitis",
                                Command = navigateCommand,
                                CommandParameter = typeof(AnkylosingSpondylitis)
                            },

                            new TextCell
                            {
                                Text = "Ehlers Danlos",
                                Command = navigateCommand,
                                CommandParameter = typeof(EhlersDanlos)
                            },

                            new TextCell
                            {
                                Text = "Marfan's Syndrome",
                                Command = navigateCommand,
                                CommandParameter = typeof(MarfansSyndrome)
                            },

                            new TextCell
                            {
                                Text = "Osteogenesis Imperfecta",
                                Command = navigateCommand,
                                CommandParameter = typeof(OsteogenesisImperfecta)
                            },

                            new TextCell
                            {
                                Text = "Rheumatoid Arthritis",
                                Command = navigateCommand,
                                CommandParameter = typeof(RheumatoidArthritis)
                            },

                            new TextCell
                            {
                                Text = "Scleroderma",
                                Command = navigateCommand,
                                CommandParameter = typeof(Scleroderma)
                            },

                            new TextCell
                            {
                                Text = "Steven Johnson Syndrome",
                                Command = navigateCommand,
                                CommandParameter = typeof(StevenJohnsonSyndrome)
                            },

                            new TextCell
                            {
                                Text = "Systemic Lupus Erythematosus (SLE)",
                                Command = navigateCommand,
                                CommandParameter = typeof(SystemicLupusErythematosusSLE)
                            },

                            new TextCell
                            {
                                Text = "Wegener's Granulomatosis",
                                Command = navigateCommand,
                                CommandParameter = typeof(WegenersGranulomatosis)
                            },

                        }
                    }
            };
        }
    }

}


