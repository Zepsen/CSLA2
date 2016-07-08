using BusinessLibrary.Models;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
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
                return getCommand ?? (getCommand = new Command(async () => await ExecuteGetCommand()));
            }
        }

        private async Task ExecuteGetCommand()
        {
            var res = BusinessLibrary.Csla.EmployeerEdit.GetPersonEdit(Convert.ToInt32(getId));

            LastName = res.LastName;
            FirstName = res.FirstName;
            Email = res.Email;            
        }

        private Command addCommand;
        public const string AddCommandPropertyName = "AddCommand";
        public Command AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new Command(async () => await ExecuteAddCommand()));
            }
        }

        private async Task ExecuteAddCommand()
        {        
            var res = BusinessLibrary.Csla.EmployeerEdit.NewPersonEdit(_employeer);
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
