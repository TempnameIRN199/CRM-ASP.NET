using CRM_system.Models.EntityDataModels.CrmSysModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRM_system.Controllers
{
    public class DetailsAboutDealController : Controller
    {

        private readonly CrmSysContext _context;

        public DetailsAboutDealController(CrmSysContext context)
        {
            _context = context;
        }
    }
}
