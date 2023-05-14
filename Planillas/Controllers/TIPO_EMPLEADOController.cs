using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planillas.Controllers
{
    public class TIPO_EMPLEADOController : ControlsController
    {
        // GET: TIPO_EMPLEADO
        public ActionResult TIPO_EMPLEADO()
        {
            return View();
        }

        // GET: TIPO_EMPLEADO/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TIPO_EMPLEADO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TIPO_EMPLEADO/Create
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

        // GET: TIPO_EMPLEADO/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TIPO_EMPLEADO/Edit/5
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

        // GET: TIPO_EMPLEADO/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TIPO_EMPLEADO/Delete/5
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
