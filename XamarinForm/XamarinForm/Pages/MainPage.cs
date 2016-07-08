using Xamarin.Forms;
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
        }

        private StackLayout GenerateMainPage()
        {
            var stack = new StackLayout();

            var labelFName = GenerateDefaultLabel("First name");
            var labelLName = GenerateDefaultLabel("Last name");
            var labelEmail = GenerateDefaultLabel("Email");

            var entryFName = new Entry();
            entryFName.SetBinding(Entry.TextProperty, EmployeerViewModel.FirstNamePropName);

            var entryLName = new Entry();
            entryLName.SetBinding(Entry.TextProperty, EmployeerViewModel.LastNamePropName);

            var entryEmail = new Entry();
            entryEmail.SetBinding(Entry.TextProperty, EmployeerViewModel.EmailPropName);

            var entryId = new Entry();
            entryId.SetBinding(Entry.TextProperty, EmployeerViewModel.IdPropName);

            var btnGet = new Button { Text = "Get" };
            btnGet.SetBinding(Button.CommandProperty, EmployeerViewModel.GetCommandPropertyName);

            var btnAdd = new Button { Text = "Add" };
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

        private Label GenerateDefaultLabel(string name = "Default label")
        {
            return new Label
            {
                Text = name,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = DefaultStyleForApp.FontSize        
            };
        }

    }
}
