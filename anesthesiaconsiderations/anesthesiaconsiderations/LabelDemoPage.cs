using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class LabelDemoPage : ContentPage
    {
        public LabelDemoPage()
        {
            Label header = new Label
            {
                Text = "About",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Label label = new Label
            {
                Text =
                    "Welcome to our website!  We aim to provide anesthesiologists, trainees, and " +

                    "perioperative health professionals with concise, current, and accessible clinical " +

                    "information.  In the 'Emergencies' section, you will find a comprehensive list of " +

                    "anesthetic emergencies, and their clinical diagnosis and management.  In the " +

                    "'Considerations' section, you will find clinically-relevant, and highly succinct " +

                    "material on the most commonly encountered co-existing diseases and surgical " +

                    "procedures.  Use the search box to quickly find your items; alternatively, you can " +

                    "use the available dropdown menus.  We hope to continually improve, expand, and " +

                    "update our website. Please read the 'Legal' section for our terms of use.",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    label
                }
            };
        }
    }
}
