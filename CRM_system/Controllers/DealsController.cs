using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRM_system.Models.EntityDataModels.CrmSysModel;
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

        public IActionResult Details(int id)
        {
            var deal = _context.Deals.Include(d => d.DealEvents)
				.Include(d => d.Client)
				.Include(d => d.Manager)
				.Include(d => d.DealEvents)
				.FirstOrDefault(d => d.Id == id);
            _context.Entry(deal.Client).Collection("ClientNotations").Load();
            if (deal == null)
            {
                return NotFound();
            }

            return View(deal);
        }
    }
}
