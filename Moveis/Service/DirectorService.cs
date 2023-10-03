using Moveis.Data.Repositories.Interface;
using Moveis.Service.Interface;
using Moveis.ViewModel.Director;
using Moveis.Data.Entity;

namespace Moveis.Service
{
    public class DirectorService:IDirectorService
    {
        private readonly IDirectorRepository _directorRepostory;
        public DirectorService(IDirectorRepository directorRepostory)
        {
            _directorRepostory = directorRepostory;
        }

        public void Add(DirectorAddEdit model)
        {
            Director entityDirector = new Director();
            entityDirector.Id = model.Id;
            entityDirector.Name = model.Name;      
            _directorRepostory.Add(entityDirector);
            _directorRepostory.SaveChanges();
        }
             

        public void Delete(int id)
        {
            var entityDirector = _directorRepostory.GetById(id);
            _directorRepostory.Delete(entityDirector);
         
        }

        public List<DirectorAddEdit> Filter()
        {
            throw new NotImplementedException();
        }

        //public List<DirectorDropDown> GetAll()
        //{
        //    var data = _directorRepostory.GetAll();
        //    return data.Select(d=> new DirectorDropDown
        //    {
        //        Id = d.Id,
        //        Name = d.Name,
        //    }).ToList();    
        //}

        public DirectorAddEdit GetById(int id)
        {
            var entityDirector = _directorRepostory.GetById(id);
            return new DirectorAddEdit()
            {
                Id = entityDirector.Id,
                Name = entityDirector.Name,

            };
        }
       
    }
}
