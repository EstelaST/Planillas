using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planillas.Controllers
{
    public class USUARIOController : ControlsController
    {
        // GET: USUARIO
        public ActionResult USUARIO()
        {
            Session["Usuario"] = null;
            Session["Nombre"] = null;
            Session["Contrasena"] = null;
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection collection, USUARIO model)
        {
            try
            {
              
                var Modelo = db.SP_DATA_USUARIO(0, model.NOMBRE, model.CONTRASENA, 3).ToList();
                if (Modelo[0].NOMBRE == model.NOMBRE && Modelo[0].CONTRASENA == model.CONTRASENA)
                {
                    Session["Usuario"] = Modelo[0].CODIGO_USUARIO;
                    Session["Nombre"] = model.NOMBRE;
                    Session["Contrasena"] = Modelo[0].CONTRASENA;
                    return RedirectToAction("AREA", "AREA");
                }
                else {
                    Session["Usuario"] = null;
                    Session["Nombre"] = null;
                    Session["Contrasena"] = null;
                    return RedirectToAction("USUARIO");
                }
            }
            catch ( Exception e)
            {
                return View("USUARIO");
            }
        }
    }
}
