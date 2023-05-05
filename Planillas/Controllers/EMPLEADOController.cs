using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planillas.Controllers
{
    public class EMPLEADOController : Controller
    {
        // GET: EMPLEADO
        public ActionResult EMPLEADO()
        {
            return View();
        }

        // GET: EMPLEADO/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EMPLEADO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EMPLEADO/Create
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

        // GET: EMPLEADO/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EMPLEADO/Edit/5
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

        // GET: EMPLEADO/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EMPLEADO/Delete/5
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
