using CRM_system.Models.EntityDataModels.CrmSysModel.Entities;
using CRM_system.Models.EntityDataModels.CrmSysModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRM_system.Controllers
{
    public class StatisticViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }

    public class StatisticsController : Controller
    {
        private readonly CrmSysContext _context;

        public StatisticsController(CrmSysContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Index()
        {
            if (TempData["UserId"] == null || TempData["UserRole"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            int id = (int)TempData["UserId"];
            string role = TempData["UserRole"].ToString();

            if (role == "Director")
            {
                var director = _context.Directors.FirstOrDefault(d => d.Id == id);

                if (director != null)
                {
                    return View(new StatisticViewModel
                    {
                        Id = director.Id,
                        Name = director.Name,
                        Role = "Director"
                    });
                }
            }
            else if (role == "Manager")
            {
                var manager = _context.Managers.FirstOrDefault(m => m.Id == id);

                if (manager != null)
                {
                    return View(new StatisticViewModel
                    {
                        Id = manager.Id,
                        Name = manager.Name,
                        Role = "Manager"
                    });
                }
            }

            return NotFound(new { message = "User not found" });
        }

        [HttpPost]
        public IActionResult DIR(string action)
        {
            if (action == "Managers")
            {
                return RedirectToAction("Index", "Managers");
            }
            else if (action == "Deals")
            {
                return RedirectToAction("Index", "Deals");
            }
            else
            {
                // Handle other cases or return a default action
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
