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
            List<TIPO_EMPLEADO> Modelo = (from c in db.TIPO_EMPLEADO select c).ToList();
            return View(Modelo);
        }

        // GET: TIPO_EMPLEADO/Details/5
        public ActionResult Details(int id)
        {
            var Modelo = (from c in db.TIPO_EMPLEADO where c.CODIGO_TIPO_EMPLEADO == id select c).Single();
            return View(Modelo);
        }

        // GET: TIPO_EMPLEADO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TIPO_EMPLEADO/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, TIPO_EMPLEADO modelo)
        {
            try
            {
                // TODO: Add insert logic here
                db.SP_MTTO_TIPO_EMPLEADO(modelo.CODIGO_TIPO_EMPLEADO, modelo.NOMBRE_TIPO_EMPLEADO, modelo.SUELDO, (int)opcion.Add);
                return RedirectToAction("TIPO_EMPLEADO");
            }
            catch
            {
                return View();
            }
        }

        // GET: TIPO_EMPLEADO/Edit/5
        public ActionResult Edit(int id)
        {
            var Modelo = (from c in db.TIPO_EMPLEADO where c.CODIGO_TIPO_EMPLEADO == id select c).Single();
            return View(Modelo);
        }

        // POST: TIPO_EMPLEADO/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection collection, TIPO_EMPLEADO modelo)
        {
            try
            {
                // TODO: Add update logic here
                db.SP_MTTO_TIPO_EMPLEADO(modelo.CODIGO_TIPO_EMPLEADO, modelo.NOMBRE_TIPO_EMPLEADO, modelo.SUELDO, (int)opcion.Update);
                return RedirectToAction("TIPO_EMPLEADO");
            }
            catch
            {
                return View();
            }
        }

        // GET: TIPO_EMPLEADO/Delete/5
        public ActionResult Delete(int id)
        {
            var Modelo = (from c in db.TIPO_EMPLEADO where c.CODIGO_TIPO_EMPLEADO == id select c).Single();
            return View(Modelo);
        }

        // POST: TIPO_EMPLEADO/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                db.SP_MTTO_TIPO_EMPLEADO(id, "",0, (int)opcion.Delete);
                return RedirectToAction("TIPO_EMPLEADO", "TIPO_EMPLEADO");

            }
            catch (Exception e)
            {
                return RedirectToAction("TIPO_EMPLEADO", "TIPO_EMPLEADO");
            }
        }
    }
}
