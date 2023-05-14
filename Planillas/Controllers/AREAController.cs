using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planillas.Controllers
{
    public class AREAController : ControlsController
    {
       

        public ActionResult AREA()
        {
            List<AREA> Modelo = (from c in db.AREA select c).ToList();

            return View(Modelo);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection, AREA modelo)
        {
            try
            {

                db.SP_MTTO_AREAS(modelo.CODIGO_AREA, modelo.NOMBRE_AREA, (int)opcion.Add);
                return RedirectToAction("AREA");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var Modelo = (from c in db.AREA where c.CODIGO_AREA == id select c).Single();

            return View(Modelo);
        }

        [HttpPost]
        public ActionResult Edit(FormCollection collection, AREA modelo)
        {
            try
            {
                db.SP_MTTO_AREAS(modelo.CODIGO_AREA, modelo.NOMBRE_AREA, (int)opcion.Update);

                return RedirectToAction("AREA");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            var Modelo = (from c in db.AREA where c.CODIGO_AREA == id select c).Single();

            return View(Modelo);
        }


        public ActionResult Delete(int id)
        {
            var Modelo = (from c in db.AREA where c.CODIGO_AREA == id select c).Single();

            return View(Modelo);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                db.SP_MTTO_AREAS(id, "", (int)opcion.Delete);

                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
