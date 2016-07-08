using BusinessLibrary.Models;

namespace BusinessLibrary.DI
{
    public interface IEmployeer
    {
        Employeer GetEmployeer(int id);
        bool CreateEmployeer(Employeer employeer);
    }
}
