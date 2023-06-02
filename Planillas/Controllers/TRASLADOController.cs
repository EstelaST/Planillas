using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planillas.Controllers
{
    public class TRASLADOController : ControlsController
    {
        // GET: TRASLADO
        public ActionResult TRASLADO()
        {
            if (Session["Usuario"] != null)
            {
                List<V_TRASLADOS> Modelo = (from c in db.V_TRASLADOS select c).ToList();

                return View(Modelo);
            }
            else
            {
                return RedirectToAction("USUARIO", "USUARIO");
            }
        }


        // GET: TRASLADO/Create
        public ActionResult Create()
        {
            List<EMPLEADO> Empleados = (from c in db.EMPLEADO select c).ToList();
            List<AREA> Areas = (from c in db.AREA select c).ToList();
            List<TIPO_EMPLEADO> Tipos = (from c in db.TIPO_EMPLEADO select c).ToList();
            Dictionary<string, string> Estados = new Dictionary<string, string>() {
                                                    { "RE","Registrado" },
                                                    { "PR"," En Proceso" },
                                                    { "AP","Aprobado" }  };

            ViewBag.EMPLEADO = Empleados;
            ViewBag.AREA = Areas;
            ViewBag.TIPO_EMPLEADO = Tipos;
            ViewBag.ESTADO = Estados; 
            return View();
        }

        // POST: TRASLADO/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, TRASLADO Modelo)
        {
            try
            {
           
                db.SP_MTTO_TRASLADOS(0, Modelo.CODIGO_EMPLEADO,Modelo.CODIGO_AREA_DESTINO,Modelo.CODIGO_TIPO_EMPLEADO_ACTUAL,Modelo.FECHA_TRASLADO,Modelo.ESTADO_TRASLADO, Session["Nombre"].ToString(), "", (int)opcion.Add);

                return RedirectToAction("TRASLADO");
            }
            catch(Exception e)
            {
                return RedirectToAction("AREA","AREA");
            }
        }

        // GET: TRASLADO/Edit/5
        public ActionResult Edit(int id)
        {
            var Modelo = (from c in db.V_TRASLADOS where c.CODIGO_TRASLADOS == id select c).Single();
            List<EMPLEADO> Empleados = (from c in db.EMPLEADO select c).ToList();
            List<AREA> Areas = (from c in db.AREA select c).ToList();
            List<TIPO_EMPLEADO> Tipos = (from c in db.TIPO_EMPLEADO select c).ToList();
            Dictionary<string, string> Estados = new Dictionary<string, string>() {
                                                    { "RE","Registrado" },
                                                    { "PR"," En Proceso" },
                                                    { "AP","Aprobado" }  };
            ViewBag.EMPLEADO = Empleados;
            ViewBag.AREA = Areas;
            ViewBag.TIPO_EMPLEADO = Tipos;
            ViewBag.ESTADO = Estados;
            return View(Modelo);
        }

        // POST: TRASLADO/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection collection, V_TRASLADOS Modelo)
        {
            try
            {

                db.SP_MTTO_TRASLADOS(Modelo.CODIGO_TRASLADOS, Modelo.CODIGO_EMPLEADO, Modelo.CODIGO_AREA_DESTINO, Modelo.CODIGO_TIPO_EMPLEADO_ACTUAL, Modelo.FECHA_TRASLADO, Modelo.ESTADO_TRASLADO, Session["Nombre"].ToString(), Session["Nombre"].ToString(), (int)opcion.Update);
                return RedirectToAction("TRASLADO");
            }
            catch (Exception e)
            {
                return RedirectToAction("AREA", "AREA");
            }
        }

        // GET: TRASLADO/Details/5
        public ActionResult Details(int id)
        {
            var Modelo = (from c in db.V_TRASLADOS where c.CODIGO_TRASLADOS == id select c).Single();

            return View(Modelo);
        }
        // GET: TRASLADO/Delete/5
        public ActionResult Delete(int id)
        {
            var Modelo = (from c in db.V_TRASLADOS where c.CODIGO_TRASLADOS == id select c).Single();

            return View(Modelo);
        }

        // POST: TRASLADO/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                db.SP_MTTO_TRASLADOS(id,0,0,0,DateTime.Now,"","","", (int)opcion.Delete);
                return RedirectToAction("TRASLADO");
            }
            catch
            {
                return RedirectToAction("AREA", "AREA");
            }
        }
    }
}
