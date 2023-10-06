using Moveis.Data.Repositories.Interface;
using Moveis.Service.Interface;
using Moveis.ViewModel.Director;
using Moveis.Data.Entity;

namespace Moveis.Service
{
    public class DirectorService:IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;
        public DirectorService(IDirectorRepository directorRepostory)
        {
            _directorRepository = directorRepostory;
        }

        public void Add(DirectorAddEdit model)
        {
            Director entityDirector = new Director();
            entityDirector.Id = model.Id;
            entityDirector.Name = model.Name;
            var Ids = GetDirectorsId();
            Ids = model.DirectorsId;
            _directorRepository.Add(entityDirector);
            _directorRepository.SaveChanges();
        }
             

        public void Delete(int id)
        {
            var entityDirector = _directorRepository.GetById(id);
            _directorRepository.Delete(entityDirector);
         
        }

        public List<DirectorAddEdit> Filter()
        {
            throw new NotImplementedException();
        }

        public List<DirectorDropDown> GetAll()
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
            var entityDirector = _directorRepository.GetById(id);
            return new DirectorAddEdit()
            {
                Id = entityDirector.Id,
                Name = entityDirector.Name,

            };
        }


        public List<DirectorDropDownViewModel> GetListForDropDown()
        {
            var directorData = _directorRepository.GetAll();
            return directorData.Select(d => new DirectorDropDownViewModel()
            {   Id = d.Id,  
                Name = d.Name,  
            }).ToList();  
        }
        private List<int> GetDirectorsId()
        {
            Director director = new Director();
             var list =  director.DirectorFilms.Select(d=>d.Id).ToList();
            return list;
        }


    }
}
