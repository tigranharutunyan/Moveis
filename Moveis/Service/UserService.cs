using Moveis.Data.Entity;
using Moveis.Data.Repositories.Interface;
using Moveis.Service.Interface;
using Moveis.ViewModel.User;

namespace Moveis.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(UserViewModel model)
        {
            var entityUser = new User()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                DOB = model.DOB,
                Login = model.Login,
                Password = model.Password,
            };
            _userRepository.Add(entityUser);
            _userRepository.SaveChanges();
        }

      

        public List<UserViewModel> GetAllUsers()
        {
            var entityUser = _userRepository.GetAll();
            return entityUser.Select(e => new UserViewModel
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                DOB = e.DOB, 
            }).ToList();
            
        }

        public UserViewModel GetById(int Id)
        {
            var entityUser =  _userRepository.GetById(Id);
            return new UserViewModel
            {
                Id = entityUser.Id,
                FirstName = entityUser.FirstName,
                LastName = entityUser.LastName,
                //Login = entityUser.Login,
                //Password = entityUser.Password,                
            };
        }

        public bool Login(UserViewModel model)
        {
            var query = _userRepository.GetAll().Any(e => (e.Login == model.Login) && (e.Password == model.Password));

            return query;
        }

    
        public void  Update(UserViewModel model)
        {
            var entityUser = _userRepository.GetById(model.Id);
            entityUser.Id = model.Id;
            entityUser.FirstName = model.FirstName;
            entityUser.LastName = model.LastName;
            entityUser.DOB = model.DOB;
            entityUser.Login = model.Login;
            entityUser.Password = model.Password;
            _userRepository.SaveChanges();

        }

    
    }
}
