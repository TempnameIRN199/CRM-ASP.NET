using CRM_system.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using CRM_system.Models.EntityDataModels.CrmSysModel;
using System.Net;
using CRM_system.EntityDataModels.CrmSysModel.Entities;

namespace CRM_system.Controllers
{
    public class HomeController : Controller
    {
        private readonly CrmSysContext _context;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, CrmSysContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            Director director = CrmSysContext.LinqQueries.GetInformationQueries.GetDirectorByAcctLogPwd(_context, email, password);
            Manager manager = CrmSysContext.LinqQueries.GetInformationQueries.GetManagerByAcctLogPwd(_context, email, password);

            if (director == null && manager != null)
            {
                TempData["UserId"] = (int)manager.Id;
                TempData["UserRole"] = "Manager";
                return RedirectToAction("Index", "Statistics");
            }
            else if (director != null && manager == null)
            {
                TempData["UserId"] = (int)director.Id;
                TempData["UserRole"] = "Director";
                return RedirectToAction("Index", "Statistics");
            }
            else if (director == null && manager == null)
            {
                return Unauthorized(new { message = "Invalid email or password" });
            }
            else
            {
                return Unauthorized(new { message = "Another error" });
            }
        }

    }
}