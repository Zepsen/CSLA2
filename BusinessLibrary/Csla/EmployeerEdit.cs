using BusinessLibrary.DI;
using BusinessLibrary.Factory;
using BusinessLibrary.Models;
using Csla;
using System;

namespace BusinessLibrary.Csla
{
    [Serializable]
    public class EmployeerEdit : BusinessBase<EmployeerEdit>
    {
        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(i => i.Id);
        public int Id
        {
            get { return GetProperty(IdProperty); }
            set { SetProperty(IdProperty, value); }
        }

        public static readonly PropertyInfo<string> FirstNameProperty = RegisterProperty<string>(i => i.FirstName);
        public string FirstName
        {
            get { return GetProperty(FirstNameProperty); }
            set { SetProperty(FirstNameProperty, value); }
        }

        public static readonly PropertyInfo<string> LastNameProperty = RegisterProperty<string>(i => i.LastName);
        public string LastName
        {
            get { return GetProperty(LastNameProperty); }
            set { SetProperty(LastNameProperty, value); }
        }

        public static readonly PropertyInfo<string> EmailProperty = RegisterProperty<string>(i => i.Email);
        public string Email
        {
            get { return GetProperty(EmailProperty); }
            set { SetProperty(EmailProperty, value); }
        }

#if !NETFX_CORE
        public static EmployeerEdit GetPersonEdit(int id)
        {
            return DataPortal.Fetch<EmployeerEdit>(id);
        }
#endif
        public static bool NewPersonEdit(Employeer employeer)
        {
            var emp = DataPortal.Create<EmployeerEdit>(employeer);

            if (emp != null)
            {
                return true;
            }

            return false;
        }

        private void DataPortal_Create(Employeer employeer)
        {
            var dal = EmployeerFactory.GetDal<IEmployeer>();
            var res = dal.CreateEmployeer(employeer);
        }

        private void DataPortal_Fetch(int id)
        {
            var dal = EmployeerFactory.GetDal<IEmployeer>();            
            var dto = dal.GetEmployeer(id);
            using (BypassPropertyChecks)
            {
                Id = dto.Id;
                FirstName = dto.FirstName;
                LastName = dto.LastName;
                Email = dto.Email;
            }
        }
    }
}
