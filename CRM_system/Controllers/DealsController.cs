using CRM_system.Models.EntityDataModels.CrmSysModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM_system.Controllers
{
    public class DealsController : Controller
    {
        public readonly CrmSysContext crmSysContext;

        public DealsController(CrmSysContext _crmSysContext)
        {
            crmSysContext = _crmSysContext;
        }

        // GET: DealsController
        public ActionResult Index()
        {

            return View();
        }

        // POST: DealsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DealsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DealsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DealsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DealsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
