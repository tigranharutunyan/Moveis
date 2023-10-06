using Microsoft.AspNetCore.Mvc;
using Moveis.Service;
using Moveis.Service.Interface;
using Moveis.ViewModel.Admin;

namespace Moveis.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        public AdminController(IAdminService adminservice) 
        { 
              _adminService = adminservice;
        }

        public IActionResult Index()
        {
           return View();
        }
        [HttpPost]
        public IActionResult Index(AdminViewModel model)
        {
            _adminService.Add(model);
            return View();
         }
        [HttpPost]
        public IActionResult LogAdmin(AdminViewModel model)
        {
            if (_adminService.LogIn(model))
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
