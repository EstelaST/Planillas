using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planillas.Controllers
{
    public class AREAController : Controller
    {
        // GET: AREA
        public ActionResult AREA()
        {
            return View();
        }

        
        // GET: AREA/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AREA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AREA/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AREA/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AREA/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AREA/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AREA/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
