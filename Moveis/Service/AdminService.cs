using Moveis.Service.Interface;
using Moveis.Data.Repositories;
using Moveis.Data.Repositories.Interface;
using Moveis.ViewModel.Admin;
using Moveis.ViewModel.User;
using Moveis.Data.Entity;
namespace Moveis.Service
{
    public class AdminService:IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public void Add(AdminViewModel model)
        {
            var entityAdmin = new Admin()
            {
                Id = model.Id,
                Name = model.Name,
                Login = model.Login,
                Password = model.Password,
            };
            _adminRepository.Add(entityAdmin);
            _adminRepository.SaveChanges();
        }

        public List<AdminViewModel> GetAllUsers()
        {
            var entityAdmin = _adminRepository.GetAll();
            return entityAdmin.Select(e => new AdminViewModel
            {
                Id = e.Id,
                Name = e.Name ,
                Login = e.Login,
                Password = e.Password,
            }).ToList();
        }

        public AdminViewModel GetById(int Id)
        {
            var entity = _adminRepository.GetById(Id);
            return new AdminViewModel
            {
                Id = entity.Id,
                Name = entity.Name ,    
                Login = entity.Login,
                Password = entity.Password,
            };
        }

        public bool LogIn(AdminViewModel model)
        {
          
            var entityAdmin  = _adminRepository.GetAll().Any(a=>((a.Login == model.Login)&&(a.Password == model.Password)));

            return entityAdmin;
         }

        public void Update(AdminViewModel model)
        {
            var entityAdmin = _adminRepository.GetById(model.Id);
            entityAdmin.Id = model.Id;
            entityAdmin.Name = model.Name;
            entityAdmin.Login = model.Login;
            entityAdmin.Password = model.Password;
            _adminRepository.Add(entityAdmin);
            _adminRepository.SaveChanges();
        }
    }
}
