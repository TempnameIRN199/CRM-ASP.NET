using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRM_system.Models.EntityDataModels.CrmSysModel;
using CRM_system.Models.EntityDataModels.CrmSysModel.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRM_system.Controllers
{
	public class DealsController : Controller
	{
		private readonly CrmSysContext _context;

		public DealsController(CrmSysContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var deals = await _context.Deals
				.Include(d => d.Client)
				.Include(d => d.Manager)
				.Include(d => d.Manager.ManagerAcctLogPwd)
				.Include(d => d.DealStatus).ToListAsync();
			return View(deals);
		}
    }
}
