using BusinessLibrary.DI;
using System;

namespace BusinessLibrary.Factory
{
    public class EmployeerFactory
    {
        public static T GetDal<T>()
        {
            Type dalType = null;
            if (typeof(T) == typeof(IEmployeer))
                dalType = Type.GetType("BusinessLibrary.DataContext.DB, BusinessLibrary");
            if (dalType != null)
                return (T)Activator.CreateInstance(dalType);
            else
                throw new Exception("Object type not found in factory");
        
        }
    }
}
