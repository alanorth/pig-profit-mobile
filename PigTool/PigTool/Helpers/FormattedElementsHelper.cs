using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.CommunityToolkit;
using Xamarin.CommunityToolkit.Behaviors;

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

        public static Label FormDataLabel(string textBindingField)
        {
            var Label = new Label()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 130
            };

            Label.SetBinding(Label.TextProperty, new Binding(textBindingField));

            return Label;
        }


        public static DatePicker FormDatePicker(string DateBindingProperty, string IsEnableBinding)
        {
            var DPicker = new DatePicker()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            DPicker.SetBinding(DatePicker.DateProperty, new Binding(DateBindingProperty));
            DPicker.SetBinding(DatePicker.IsEnabledProperty, new Binding(IsEnableBinding));

            return DPicker;
        }

        public static Entry FormNumericEntry(string TextBindingProperty, string IsEnableBinding, string InvladiStyleBinding,int min = 0, int max = 2000)
        {
            var Entry = new Entry()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Keyboard = Keyboard.Numeric
            };

            Entry.SetBinding(Entry.TextProperty, new Binding(TextBindingProperty));
            Entry.SetBinding(Entry.IsEnabledProperty, new Binding(IsEnableBinding));

            var NVB = new NumericValidationBehavior()
            {
                MinimumValue = min,
                MaximumValue = max,
            };

            //NVB.SetBinding(NumericValidationBehavior.InvalidStyleProperty, new Binding(InvladiStyleBinding));

            Entry.Behaviors.Add(NVB);

            return Entry;
        }


        public static Entry FormTextEntry(string TextBindingProperty, string IsEnableBinding,string ViewHideBinding = null , bool IsVisibile = true )
        {
            var Entry = new Entry()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Entry.SetBinding(Entry.TextProperty, new Binding(TextBindingProperty));
            Entry.SetBinding(Entry.IsEnabledProperty, new Binding(IsEnableBinding));

            if (!IsVisibile &&  !string.IsNullOrWhiteSpace(ViewHideBinding))
            {
                //inmplment a catch if ViewHideBinding is not provided

                Entry.SetBinding(Entry.IsVisibleProperty, new Binding(ViewHideBinding));
            }
            return Entry;
        }

        public static Picker  FormPickerEntry (string ItemSourceBinding, string ItemDisplayBinding, string SelectedItemBinding, string IsEnabledBinding)
        {
            Picker picker = new Picker()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            picker.SetBinding(Picker.SelectedItemProperty, new Binding(SelectedItemBinding));
            picker.SetBinding(Picker.ItemsSourceProperty, new Binding(ItemSourceBinding));
            picker.ItemDisplayBinding = new Binding(ItemDisplayBinding);

            return picker;
        }

        public static StackLayout TableRowStack(string isVisibleBinding =  null, bool hiddenField = false, StackOrientation stackOrientation = StackOrientation.Horizontal)
        {
            var stack = new StackLayout()
            {
                Orientation = stackOrientation,
                Padding = 10
            };

            if (hiddenField)
            {
                stack.SetBinding(StackLayout.IsVisibleProperty, new Binding(isVisibleBinding));
            }

            return stack;
        }

        public static StackLayout ButtonCommandStack(
            string ResetCommandBinding,
            string EditCommandBinding,
            string DeleteCommandBinding,
            string SaveCommandBinding,
            string EditModeBinding,
            string ExistingModeBinding,
            string ResetText,
            string SaveText,
            string DeleteText,
            string EditText
            )
        {
            var stack = TableRowStack();

            var resertButton = new Button();
            resertButton.Text = ResetText;
            resertButton.SetBinding(Button.CommandProperty, new Binding(ResetCommandBinding));
            resertButton.SetBinding(Button.IsVisibleProperty, new Binding(EditModeBinding));
            resertButton.SetBinding(Button.IsEnabledProperty, new Binding(EditModeBinding));
            var editButton = new Button();
            editButton.Text = EditText;
            editButton.SetBinding(Button.CommandProperty, new Binding(EditCommandBinding));
            editButton.SetBinding(Button.IsVisibleProperty, new Binding(ExistingModeBinding));
            var deleteButton = new Button();
            deleteButton.Text = DeleteText;
            deleteButton.SetBinding(Button.CommandProperty, new Binding(DeleteCommandBinding));
            deleteButton.SetBinding(Button.IsVisibleProperty, new Binding(ExistingModeBinding));
            deleteButton.SetBinding(Button.IsEnabledProperty, new Binding(EditModeBinding));
            var saveButton = new Button();
            saveButton.Text = SaveText;
            saveButton.SetBinding(Button.CommandProperty, new Binding(SaveCommandBinding));
            saveButton.SetBinding(Button.IsVisibleProperty, new Binding(EditModeBinding));
            saveButton.SetBinding(Button.IsEnabledProperty, new Binding(EditModeBinding));

            stack.Children.Add(resertButton);
            stack.Children.Add(editButton);
            stack.Children.Add(deleteButton);
            stack.Children.Add(saveButton);

            return stack;
        }

        public static Slider FormSliderInput()
        {


            Slider slider = new Slider
            {
                Maximum = 360
            };

            return slider;

           
        }


    }
}
