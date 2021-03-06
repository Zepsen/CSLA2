﻿using Xamarin.Forms;
using XamarinForm.Pages.DefaultStyle;
using XamarinForm.ViewModels;

namespace XamarinForm.Pages
{
    class MainPage : ContentPage
    {
        public MainPage()
        {
            var stack = GenerateMainPage();
            BindingContext = new EmployeerViewModel();
            Content = stack;
            Title = "CSLA";            
        }

        private StackLayout GenerateMainPage()
        {
            var stack = new StackLayout { Padding = new Thickness(50, 0), Spacing = 10 };

            var labelFName = GenerateDefaultLabel("First name");
            var labelLName = GenerateDefaultLabel("Last name");
            var labelEmail = GenerateDefaultLabel("Email");

            var entryFName = new Entry() { HorizontalTextAlignment = TextAlignment.Center };
            entryFName.SetBinding(Entry.TextProperty, EmployeerViewModel.FirstNamePropName);
            entryFName.SetBinding(Entry.BackgroundColorProperty, EmployeerViewModel.FirstNameBCPropName);

            var entryLName = new Entry() { HorizontalTextAlignment = TextAlignment.Center };
            entryLName.SetBinding(Entry.TextProperty, EmployeerViewModel.LastNamePropName);
            entryLName.SetBinding(Entry.BackgroundColorProperty, EmployeerViewModel.LastNameBCPropName);

            var entryEmail = new Entry() { HorizontalTextAlignment = TextAlignment.Center };
            entryEmail.SetBinding(Entry.TextProperty, EmployeerViewModel.EmailPropName);
            entryEmail.SetBinding(Entry.BackgroundColorProperty, EmployeerViewModel.EmailBCPropName);

            var entryId = new Entry() { HorizontalTextAlignment = TextAlignment.Center };
            entryId.SetBinding(Entry.TextProperty, EmployeerViewModel.IdPropName);

            var btnGet = GetDefaultButton("Get");
            btnGet.SetBinding(Button.CommandProperty, EmployeerViewModel.GetCommandPropertyName);

            var btnAdd = GetDefaultButton("Add");
            btnAdd.SetBinding(Button.CommandProperty, EmployeerViewModel.AddCommandPropertyName);
            
            stack.Children.Add(labelFName);
            stack.Children.Add(entryFName);

            stack.Children.Add(labelLName);
            stack.Children.Add(entryLName);

            stack.Children.Add(labelEmail);
            stack.Children.Add(entryEmail);

            stack.Children.Add(entryId);

            stack.Children.Add(btnGet);
            stack.Children.Add(btnAdd);
                        
            return stack;
        }

        private static Button GetDefaultButton(string btnName = "Button")
        {
            return new Button
            {
                Text = btnName,
                BorderColor = DefaultStyleForApp.FontColor,
                TextColor = DefaultStyleForApp.FontColor                               
            };
        }

        private Label GenerateDefaultLabel(string labelName = "Default label")
        {
            return new Label
            {
                Text = labelName,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = DefaultStyleForApp.FontSize,
                TextColor = DefaultStyleForApp.FontColor
            };
        }

    }
}
