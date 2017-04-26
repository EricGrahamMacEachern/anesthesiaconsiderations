using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Psychiatric : ContentPage
    {
        public Psychiatric()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Psychiatric";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Psychiatric")
                        {
                            new TextCell
                            {
                                Text = "Electroconvulsive Therapy (ECT)",
                                Command = navigateCommand,
                                CommandParameter = typeof(ElectroconvulsiveTherapyECT)
                            },

                            new TextCell
                            {
                                Text = "MOAI (Monoamine Oxidase Inhibitors)",
                                Command = navigateCommand,
                                CommandParameter = typeof(MOAIMonoamineOxidaseInhibitors)
                            },

                            new TextCell
                            {
                                Text = "Neuroleptic Malignant Syndrome",
                                Command = navigateCommand,
                                CommandParameter = typeof(NeurolepticMalignantSyndrome)
                            },

                            new TextCell
                            {
                                Text = "Serotonin Syndrome",
                                Command = navigateCommand,
                                CommandParameter = typeof(SerotoninSyndrome)
                            },

                        }
                    }
            };
        }
    }

}


