using CRM_system.Models.EntityDataModels.CrmSysModel.Entities;
using CRM_system.Models.EntityDataModels.CrmSysModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRM_system.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly CrmSysContext _context;

        public RegistrationController(CrmSysContext context)
        {
            _context = context;
        }

        // GET: RegistrationController
        public ActionResult Index()
        {
            return View();
        }

        // POST: RegistrationController/Edit/
        [HttpPost]
        public IActionResult Registration(string email, string phone, string fullname,
            string login, string password, string companyName, string dateCreate)
        {
            string[] fullnameArr = fullname.Split(' ');
            string newSurname = fullnameArr[0];
            string newName = fullnameArr[1];
            string newPatronymic = fullnameArr[2];

            DirectorAcctLogPwd directorAcctLogPwd = new DirectorAcctLogPwd(login, password, null);

            Company company = new Company(companyName, DateTime.Parse(dateCreate), null);

            Director dir = new Director(newSurname, newName, newPatronymic, phone, email, null, null);

            CrmSysContext.LinqQueries.AddEntityQueries.AddCompanyDirectorAcct(_context, company, dir, directorAcctLogPwd);

            return RedirectToAction("Index", "Home");
        }
    }
}
