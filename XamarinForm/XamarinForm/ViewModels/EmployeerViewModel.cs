using BusinessLibrary.Models;
using System;
using System.ComponentModel;
using Xamarin.Forms;


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
            SetEmployeerToForm(employeer);
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
            if (BusinessLibrary.Csla.EmployeerEdit.NewPersonEdit(_employeer))
            {
                ClearForm();
            };
        }
        private void ClearForm()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
