using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planillas.Controllers
{
    public class EMPLEADOController : ControlsController
    {
        // GET: EMPLEADO
        public ActionResult EMPLEADO()
        {
            if (Session["Usuario"] != null)
            {
                List<V_EMPLEADOS> Modelo = (from c in db.V_EMPLEADOS select c).ToList();

                return View(Modelo);
            }
            else
            {
                return RedirectToAction("USUARIO", "USUARIO");
            }
        }

        // GET: EMPLEADO/Details/5
        public ActionResult Details(int id)
        {
            var Modelo = (from c in db.V_EMPLEADOS where c.CODIGO_EMPLEADO == id select c).Single();
            return View(Modelo);
        }

        // GET: EMPLEADO/Create
        public ActionResult Create()
        {
            List<PAIS> Paises = (from c in db.PAIS select c).ToList();
            List<DEPARTAMENTO> Departamentos = (from c in db.DEPARTAMENTO select c).ToList();
            List<MUNICIPIO> Municipios = (from c in db.MUNICIPIO select c).ToList();
            List<AREA> Areas = (from c in db.AREA select c).ToList();
            List<TIPO_EMPLEADO> Tipos = (from c in db.TIPO_EMPLEADO select c).ToList();
            Dictionary<string, string> Sexo = new Dictionary<string, string>() {
                                                    { "F","Femenino" },
                                                    { "M","Masculino" },
                                                    { "O","Otro" }  };
            Dictionary<string, string> Estados = new Dictionary<string, string>() {
                                                    { "SO","Soltero" },
                                                    { "CA","Casado" },
                                                    { "DI","Divorciado" },
                                                    { "VI","Viudo" }};
            Dictionary<string, string> Afps = new Dictionary<string, string>() {
                                                    { "CRE","Crecer" },
                                                    { "CON","Confia" },
                                                    { "OTR","Otro" }  };

            ViewBag.PAIS = Paises;
            ViewBag.DEPARTAMENTO = Departamentos;
            ViewBag.MUNICIPIO = Municipios;
            ViewBag.AREA = Areas;
            ViewBag.TIPO_EMPLEADO = Tipos;
            ViewBag.SEXO = Sexo;
            ViewBag.ESTADO = Estados;
            ViewBag.AFP = Afps;
            return View();
        }

        // POST: EMPLEADO/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, EMPLEADO Modelo)
        {
            try
            {
                db.SP_MTTO_EMPLEADO(0, 
                                    Modelo.PRIMER_NOMBRE,
                                    Modelo.SEGUNDO_NOMBRE,
                                    Modelo.PRIMER_APELLIDO,
                                    Modelo.SEGUNDO_APELLIDO,
                                    Modelo.FECHA_NACIMIENTO,
                                    Modelo.SEXO,
                                    Modelo.PAIS,
                                    Modelo.DEPARTAMENTO,
                                    Modelo.MUNICIPIO,
                                    Modelo.DIRECCION,
                                    Modelo.ESTADO_CIVIL,
                                    Modelo.TELEFONO,
                                    Modelo.CORREO_ELECTRONICO,
                                    Modelo.LUGAR_NACIMIENTO,
                                    Modelo.DUI,
                                    Modelo.NIT,
                                    Modelo.AFP,
                                    Modelo.SEGURO,
                                    Modelo.NUP,
                                    Modelo.TIPO_EMPLEADO,
                                    Modelo.FECHA_INGRESO,
                                    Modelo.FECHA_RETIRO,
                                    Session["Nombre"].ToString(),
                                    "",
                                    Modelo.ACTIVO,
                                    Modelo.AREA,
                                    (int)opcion.Add);

                return RedirectToAction("EMPLEADO");
            }
            catch (Exception e)
            {
                return RedirectToAction("EMPLEADO", "EMPLEADO");
            }
        }

        // GET: EMPLEADO/Edit/5
        public ActionResult Edit(int id)
        {
            var Modelo = (from c in db.V_EMPLEADOS where c.CODIGO_EMPLEADO == id select c).Single();
            List<PAIS> Paises = (from c in db.PAIS select c).ToList();
            List<DEPARTAMENTO> Departamentos = (from c in db.DEPARTAMENTO select c).ToList();
            List<MUNICIPIO> Municipios = (from c in db.MUNICIPIO select c).ToList();
            List<AREA> Areas = (from c in db.AREA select c).ToList();
            List<TIPO_EMPLEADO> Tipos = (from c in db.TIPO_EMPLEADO select c).ToList();
            Dictionary<string, string> Sexo = new Dictionary<string, string>() {
                                                    { "F","Femenino" },
                                                    { "M","Masculino" },
                                                    { "O","Otro" }  };
            Dictionary<string, string> Estados = new Dictionary<string, string>() {
                                                    { "SO","Soltero" },
                                                    { "CA","Casado" },
                                                    { "DI","Divorciado" },
                                                    { "VI","Viudo" }};
            Dictionary<string, string> Afps = new Dictionary<string, string>() {
                                                    { "CRE","Crecer" },
                                                    { "CON","Confia" },
                                                    { "OTR","Otro" }  };

            ViewBag.PAIS = Paises;
            ViewBag.DEPARTAMENTO = Departamentos;
            ViewBag.MUNICIPIO = Municipios;
            ViewBag.AREA = Areas;
            ViewBag.TIPO_EMPLEADO = Tipos;
            ViewBag.SEXO = Sexo;
            ViewBag.ESTADO = Estados;
            ViewBag.AFP = Afps;

            return View(Modelo);
        }

        // POST: EMPLEADO/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection collection, V_EMPLEADOS Modelo)
        {
            try
            {
                db.SP_MTTO_EMPLEADO(Modelo.CODIGO_EMPLEADO,
                                   Modelo.PRIMER_NOMBRE,
                                   Modelo.SEGUNDO_NOMBRE,
                                   Modelo.PRIMER_APELLIDO,
                                   Modelo.SEGUNDO_APELLIDO,
                                   Modelo.FECHA_NACIMIENTO,
                                   Modelo.SEXO,
                                   Modelo.PAIS,
                                   Modelo.DEPARTAMENTO,
                                   Modelo.MUNICIPIO,
                                   Modelo.DIRECCION,
                                   Modelo.ESTADO_CIVIL,
                                   Modelo.TELEFONO,
                                   Modelo.CORREO_ELECTRONICO,
                                   Modelo.LUGAR_NACIMIENTO,
                                   Modelo.DUI,
                                   Modelo.NIT,
                                   Modelo.AFP,
                                   Modelo.SEGURO,
                                   Modelo.NUP,
                                   Modelo.TIPO_EMPLEADO,
                                   Modelo.FECHA_INGRESO,
                                   Modelo.FECHA_RETIRO,
                                   Session["Nombre"].ToString(),
                                   Session["Nombre"].ToString(),
                                   Modelo.ACTIVO,
                                   Modelo.AREA,
                                   (int)opcion.Update);

                return RedirectToAction("EMPLEADO");
            }
            catch (Exception e)
            {
                return RedirectToAction("EMPLEADO", "EMPLEADO");
            }
        }

        // GET: EMPLEADO/Delete/5
        public ActionResult Delete(int id)
        {
            var Modelo = (from c in db.V_EMPLEADOS where c.CODIGO_EMPLEADO == id select c).Single();

            return View(Modelo);
        }

        // POST: EMPLEADO/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                db.SP_MTTO_EMPLEADO(id, "", "", "", "", DateTime.Now, ' ', 0, 0, 0, "", "", "","","","","","","","",0, DateTime.Now, DateTime.Now, "", "", false, 0, (int)opcion.Delete);

                return RedirectToAction("EMPLEADO");
            }
            catch
            {
                return RedirectToAction("EMPLEADO", "EMPLEADO");
            }
        }
    }
}
