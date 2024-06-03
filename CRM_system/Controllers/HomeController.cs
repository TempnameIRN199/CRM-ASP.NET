using CRM_system.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using CRM_system.Models.EntityDataModels.CrmSysModel;
using CRM_system.Models.EntityDataModels.CrmSysModel.Entities;
using System.Net;

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
            List<DirectorAcctLogPwd> dirLog = CrmSysContext.LinqQueries.GetInformationQueries.GetAllLoginDirector(_context);
            DirectorAcctLogPwd director = dirLog.FirstOrDefault(d => d.Login == email && d.Password == password);
            if (director != null)
            {
                return View("/Statistics/Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
