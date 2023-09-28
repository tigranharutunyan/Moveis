using Moveis.ViewModel.Admin;
using Moveis.ViewModel.Director;

namespace Moveis.Service.Interface
{
    public interface IDirectorService
    {
        void Add(DirectorAddEdit model);
        void Delete(int id);
        DirectorAddEdit GetById(int id);
        //List<DirectorAddEdit> GetAll();
         

       
    }
}
