using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PigTool.Helpers
{
    public static class FormattedElementsHelper
    {
        public static Label ManageDataLabel(string text)
        {
            var label = new Label
            {
                Text = text,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 18,
                BackgroundColor = Color.FromHex("#b35137"),
                LineBreakMode = LineBreakMode.WordWrap,
                FontAttributes = FontAttributes.Bold,

            };

            return label;
        }

        public static Label ManageDataDetailsLableField(string labelBindingField)
        {
            var label = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 15,
                BackgroundColor = Color.White,
                LineBreakMode = LineBreakMode.WordWrap

            };

            label.SetBinding(Label.TextProperty, new Binding(labelBindingField));

            return label;
        }

    }
}
