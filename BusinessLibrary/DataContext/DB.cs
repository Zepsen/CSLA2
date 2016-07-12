using BusinessLibrary.DI;
using BusinessLibrary.Models;
using BusinessLibrary.Repo;


namespace BusinessLibrary.DataContext
{
    class DB : IEmployeer
    {
        private EmployeerRepo repo;
        
        public DB()
        {
            repo = new EmployeerRepo("employeer.db");            
        }

        public bool CreateEmployeer(Employeer employeer)
        {
            try
            {
                repo.SaveItem(employeer);
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        public Employeer GetEmployeer(int id)
        {                 
            return repo.GetItem(id);
        }
        
    }
}
