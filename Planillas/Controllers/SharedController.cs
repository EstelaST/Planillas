using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planillas.Controllers
{
    public class SharedController : Controller
    {

        public ActionResult _Layout()
        {
            return View();
        }
        public ActionResult _Content()
        {
            return View();
        }
    }
}
