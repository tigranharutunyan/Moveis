using Moveis.ViewModel.Admin;
using Moveis.ViewModel.User;

namespace Moveis.Service.Interface
{
    public interface IAdminService
    {
        void Add(AdminViewModel model);
        void Update(AdminViewModel model);
        bool LogIn(AdminViewModel model);
        public AdminViewModel GetById(int id);
        public List<AdminViewModel> GetAllUsers();

    }
}
