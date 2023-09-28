using Moveis.ViewModel.User;

namespace Moveis.Service.Interface
{
    public interface IUserService
    {
        public void Add(UserViewModel model);
     
        public void Update(UserViewModel model);
        public UserViewModel GetById(int Id);
        public List<UserViewModel> GetAllUsers();
        public bool Login(UserLogViewModel model);
    }
}
