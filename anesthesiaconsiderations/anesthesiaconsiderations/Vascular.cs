using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Vascular : ContentPage
    {
        public Vascular()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Vascular";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Vascular")
                        {
                            new TextCell
                            {
                                Text = "Abdominal Aortic Aneurysm Repair(Open)",
                                Command = navigateCommand,
                                CommandParameter = typeof(AbdominalAorticAneurysmRepairOpen)
                            },

                            new TextCell
                            {
                                Text = "Carotid Endarterectomy",
                                Command = navigateCommand,
                                CommandParameter = typeof(CarotidEndarterectomy)
                            },

                        }
                    }
            };
        }
    }

}




