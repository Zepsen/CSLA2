using BusinessLibrary.Models;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using XamarinForm.Pages.DefaultStyle;

namespace XamarinForm.ViewModels
{
    public class EmployeerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Employeer _employeer = new Employeer();

        public EmployeerViewModel()
        {

        }

        public const string FirstNamePropName = "FirstName";
        public string FirstName
        {
            get
            {
                return _employeer.FirstName;
            }
            set
            {
                _employeer.FirstName = value;
                OnPropertyChanged(nameof(Employeer.FirstName));
            }
        }

        private Color firstNameDB = Color.White;
        public const string FirstNameBCPropName = "FirstNameBC";
        public Color FirstNameBC
        {
            get
            {
                return firstNameDB;
            }
            set
            {
                firstNameDB = value;
                OnPropertyChanged("FirstNameBC");
            }
        }

        public const string LastNamePropName = "LastName";
        public string LastName
        {
            get
            {
                return _employeer.LastName;
            }
            set
            {
                _employeer.LastName = value;
                OnPropertyChanged(nameof(Employeer.LastName));
            }
        }

        private Color lastNameDB = Color.White;
        public const string LastNameBCPropName = "LastNameBC";
        public Color LastNameBC
        {
            get
            {
                return lastNameDB;
            }
            set
            {
                lastNameDB = value;
                OnPropertyChanged("LastNameBC");
            }
        }

        public const string EmailPropName = "Email";
        public string Email
        {
            get
            {
                return _employeer.Email;
            }
            set
            {
                _employeer.Email = value;
                OnPropertyChanged(nameof(Employeer.Email));
            }
        }

        private Color emailDB = Color.White;
        public const string EmailBCPropName = "EmailBC";
        public Color EmailBC
        {
            get
            {
                return emailDB;
            }
            set
            {
                emailDB = value;
                OnPropertyChanged("EmailBC");
            }
        }

        public string getId { get; set; }
        public const string IdPropName = "GetId";
        public string GetId
        {
            get
            {
                return getId;
            }
            set
            {
                getId = value;
                OnPropertyChanged(nameof(getId));
            }
        }

        private Command getCommand;
        public const string GetCommandPropertyName = "GetCommand";
        public Command GetCommand
        {
            get
            {
                return getCommand ?? (getCommand = new Command(() => ExecuteGetCommand()));
            }
        }
        private void ExecuteGetCommand()
        {
            var employeer = BusinessLibrary.Csla.EmployeerEdit.GetPersonEdit(Convert.ToInt32(getId));
            if(employeer != null)
            {
                SetDefaultColorToForm();
                SetEmployeerToForm(employeer);
            }
            
        }
        private void SetEmployeerToForm(BusinessLibrary.Csla.EmployeerEdit employeer)
        {
            LastName = employeer.LastName;
            FirstName = employeer.FirstName;
            Email = employeer.Email;
        }

        private Command addCommand;
        public const string AddCommandPropertyName = "AddCommand";
        public Command AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new Command(() => ExecuteAddCommand()));
            }
        }
        private void ExecuteAddCommand()
        {
            if (ValidateForm())
            {
                TryAddPerson();
            }
            else
            {
                ValidateColorForm();
            }
        }

        private void TryAddPerson()
        {
            if (BusinessLibrary.Csla.EmployeerEdit.NewPersonEdit(_employeer))
            {
                SetDefaultColorToForm();
                ClearForm();
            };
        }

        private void ClearForm()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
        }

        private bool ValidateForm()
        {
            return !string.IsNullOrEmpty(_employeer.FirstName)
                && !string.IsNullOrEmpty(_employeer.LastName)
                && !string.IsNullOrEmpty(_employeer.Email);
        }

        private void ValidateColorForm()
        {
            FirstNameBC = string.IsNullOrEmpty(_employeer.FirstName) ? DefaultStyleForApp.ErrorColor : DefaultStyleForApp.SuccessColor;
            LastNameBC = string.IsNullOrEmpty(_employeer.LastName) ? DefaultStyleForApp.ErrorColor : DefaultStyleForApp.SuccessColor;
            EmailBC = string.IsNullOrEmpty(_employeer.Email) ? DefaultStyleForApp.ErrorColor : DefaultStyleForApp.SuccessColor;
        }

        private void SetDefaultColorToForm()
        {
            FirstNameBC = Color.White;
            LastNameBC = Color.White;
            EmailBC = Color.White;
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
