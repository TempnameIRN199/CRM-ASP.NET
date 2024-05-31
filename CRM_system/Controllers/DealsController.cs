using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM_system.Controllers
{
    public class DealsController : Controller
    {
        // GET: DealsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DealsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DealsController/Create
        public ActionResult Create()
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
