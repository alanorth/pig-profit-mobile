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
                FontSize = 15,
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("#682622"),
                LineBreakMode = LineBreakMode.WordWrap,
                Padding = new Thickness(8),
            };

            return label;
        }

        public static Label ManageDataDetailsLabelField(string labelBindingField)
        {
            var label = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 13,
                BackgroundColor = Color.White,
                LineBreakMode = LineBreakMode.WordWrap,
                
            };

            label.SetBinding(Label.TextProperty, new Binding(labelBindingField));

            return label;
        }

        public static Label ReportTableLabelField(string labelBindingField)
        {
            var label = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 16,
                BackgroundColor = Color.White,
                LineBreakMode = LineBreakMode.WordWrap,

            };

            label.SetBinding(Label.TextProperty, new Binding(labelBindingField));

            return label;
        }

        public static Label ReportTableHeaderLabelField(string labelBindingField)
        {

            var label = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 16,
                LineBreakMode = LineBreakMode.WordWrap,
                Text = labelBindingField,
                StyleClass = new List<string> { "ReportTableHeader" }
            };

            return label;
        }

        public static Label DataLabel(string textBindingField)
        {
            var Label = new Label()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            Label.SetBinding(Label.TextProperty, new Binding(textBindingField));

            return Label;
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
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            DPicker.SetBinding(DatePicker.DateProperty, new Binding(DateBindingProperty));
            DPicker.SetBinding(DatePicker.IsEnabledProperty, new Binding(IsEnableBinding));

            return DPicker;
        }

        public static void Entry_TextChanged(object sender, TextChangedEventArgs e) 
        { 
            var oldText = e.OldTextValue; 
            var newText = e.NewTextValue; 

            if (string.IsNullOrWhiteSpace(newText))
            {
                var entry = (Entry)sender;
                entry.Text = null;
            }
        }

        public static Entry FormNumericEntry(string TextBindingProperty, string IsEnableBinding, string InvladiStyleBinding,int min = 0, int max = 2000)
        {
            var Entry = new Entry()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Keyboard = Keyboard.Numeric,
                Placeholder = "",
                BackgroundColor = Color.White,
            };

            Entry.SetBinding(Entry.TextProperty, new Binding(TextBindingProperty));
            Entry.SetBinding(Entry.IsEnabledProperty, new Binding(IsEnableBinding));
            Entry.TextChanged += Entry_TextChanged;

            var NVB = new NumericValidationBehavior()
            {
                MinimumValue = min,
                MaximumValue = max,
            };

            //NVB.SetBinding(NumericValidationBehavior.InvalidStyleProperty, new Binding(InvladiStyleBinding));

            Entry.Behaviors.Add(NVB);

            return Entry;
        }


        public static Entry FormTextEntry(string TextBindingProperty, string IsEnableBinding,string ViewHideBinding = null,  bool IsVisibile = true,  string startingvalue = null )
        {
            var Entry = new Entry()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                //HeightRequest = heightRequest,
                Placeholder = ""
            };

            Entry.SetBinding(Entry.TextProperty, new Binding(TextBindingProperty));
            Entry.SetBinding(Entry.IsEnabledProperty, new Binding(IsEnableBinding));

            if (!IsVisibile &&  !string.IsNullOrWhiteSpace(ViewHideBinding))
            {
                //inmplment a catch if ViewHideBinding is not provided

                Entry.SetBinding(Entry.IsVisibleProperty, new Binding(ViewHideBinding));
            }

            if (!string.IsNullOrEmpty(startingvalue))
            {
                Entry.Text = startingvalue;
            }
            return Entry;
        }

        public static Entry FormEditorEntry(string TextBindingProperty, string IsEnableBinding, string ViewHideBinding = null, bool IsVisibile = true, int heightRequest = -1)
        {
            var Edds = new Entry()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                //HeightRequest = heightRequest,
                Placeholder = ""
            };

            Edds.SetBinding(Editor.TextProperty, new Binding(TextBindingProperty));
            Edds.SetBinding(Editor.IsEnabledProperty, new Binding(IsEnableBinding));

            if (!IsVisibile && !string.IsNullOrWhiteSpace(ViewHideBinding))
            {
                //inmplment a catch if ViewHideBinding is not provided

                Edds.SetBinding(Editor.IsVisibleProperty, new Binding(ViewHideBinding));
            }
            return Edds;
        }

        public static Picker  FormPickerEntry (string ItemSourceBinding, string ItemDisplayBinding, string SelectedItemBinding, string IsEnabledBinding, PickerToolHelper  selectedItem = null, string hintText = "")
        {
            Picker picker = new Picker()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Title = hintText
            };

            picker.SetBinding(Picker.SelectedItemProperty, new Binding(SelectedItemBinding));
            picker.SetBinding(Picker.ItemsSourceProperty, new Binding(ItemSourceBinding));
            picker.SetBinding(Picker.IsEnabledProperty, new Binding(IsEnabledBinding));
            picker.ItemDisplayBinding = new Binding(ItemDisplayBinding);

            picker.SelectedIndexChanged += (sender, e) =>
            {
                if(picker.SelectedItem == null)
                {
                    picker.SelectedIndex = -1;
                }
            };

            return picker;
        }

        public static StackLayout TableRowStack(string isVisibleBinding =  null, bool hiddenField = false, StackOrientation stackOrientation = StackOrientation.Horizontal)
        {
            var stack = new StackLayout()
            {
                Orientation = stackOrientation,
                Padding = 10,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            if (hiddenField)
            {
                stack.SetBinding(StackLayout.IsVisibleProperty, new Binding(isVisibleBinding));
            }

            return stack;
        }

        public static Grid TableRowGrid(string isVisibleBinding = null, bool hiddenField = false, GridFields fields = GridFields.Two)
        {
            Grid objGrid = new Grid()
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = 10
            };

            if (fields == GridFields.Two) { 
                
                objGrid.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
                objGrid.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
                objGrid.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                }); objGrid.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                }); objGrid.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
            }
            else if (fields == GridFields.Three)
            {
                objGrid.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
                objGrid.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
                objGrid.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
            }

            if (hiddenField)
            {
                objGrid.SetBinding(StackLayout.IsVisibleProperty, new Binding(isVisibleBinding));
            }

            return objGrid;
        }

        public static void AddGridValue(Grid grid, View view, GridPostion gridPostion)
        {
            if(gridPostion == GridPostion.TwoLeft)
                grid.Children.Add(view, left: 0, right: 2, top: 0, bottom: 1);

            if (gridPostion == GridPostion.TwoRight) 
                grid.Children.Add(view, left: 2, right: 5, top: 0, bottom: 1);

            if (gridPostion == GridPostion.ThreeLeft) 
                grid.Children.Add(view, left: 0, right: 1, top: 0, bottom: 1);

            if (gridPostion == GridPostion.ThreeCenter)
                grid.Children.Add(view, left: 1, right: 2, top: 0, bottom: 1);

            if (gridPostion == GridPostion.ThreeRight)
                grid.Children.Add(view, left: 2, right: 3, top: 0, bottom: 1);
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
            stack.Margin = new Thickness( 0, 20, 0, 20);
            stack.Padding = 0;
            //stack.SetBinding(VisualElement.IsVisibleProperty, new Binding(ExistingModeBinding));

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
            saveButton.HorizontalOptions = LayoutOptions.FillAndExpand;

            stack.Children.Add(resertButton);
            stack.Children.Add(editButton);
            stack.Children.Add(deleteButton);
            stack.Children.Add(saveButton);

            return stack;
        }

        // Custom slider input using the community range selector. Lower values have been hidden with the intention of only binding the upper value
        public static Xamarin.CommunityToolkit.UI.Views.RangeSlider FormSliderInput(string TextBindingProperty, string IsEnableBinding, string ViewHideBinding = null, bool IsVisibile = true, int upperValue = 10)
        {

            Xamarin.CommunityToolkit.UI.Views.RangeSlider slider = new Xamarin.CommunityToolkit.UI.Views.RangeSlider()
            {
                MinimumValue = 1,
                MaximumValue = upperValue,
                LowerValue = 1,
                UpperValue = upperValue,
                StepValue = 1,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 70,
                LowerThumbSize = 0,
                LowerValueLabelStyle = (Style)Application.Current.Resources["SliderLowerValueLabelStyle"]
            };

            slider.SetBinding(Xamarin.CommunityToolkit.UI.Views.RangeSlider.UpperValueProperty, new Binding(TextBindingProperty));
            slider.SetBinding(VisualElement.IsEnabledProperty, new Binding(IsEnableBinding));

            if (!IsVisibile && !string.IsNullOrWhiteSpace(ViewHideBinding))
            {
                //inmplment a catch if ViewHideBinding is not provided

                slider.SetBinding(VisualElement.IsVisibleProperty, new Binding(ViewHideBinding));
            }
            return slider;
           
        }
    }
}
