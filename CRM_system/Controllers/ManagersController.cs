using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM_system.Controllers
{
    public class ManagersController : Controller
    {
        // GET: ManagersController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ManagersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManagersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManagersController/Create
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

        // GET: ManagersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManagersController/Edit/5
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

        // GET: ManagersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManagersController/Delete/5
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
