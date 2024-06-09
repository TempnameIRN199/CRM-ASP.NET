using CRM_system.Models.EntityDataModels.CrmSysModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRM_system.Controllers
{
    public class ManagersController : Controller
    {

        private readonly CrmSysContext _context;

        public ManagersController(CrmSysContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var managers = await _context.Managers
                .Include(d => d.ManagerAcctLogPwd).ToListAsync();
            return View(managers);
        }
    }
}
