using Microsoft.AspNetCore.Mvc;
using Moveis.Service.Interface;

namespace Moveis.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        public AdminController(IAdminService adminservice) { 
              _adminService = adminservice;
         }

        public IActionResult Index()
        {
            return View();
         }

        //public IActionResult AdminIndex()
        //{

        //}
    }
}
