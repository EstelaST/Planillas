using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planillas.Controllers
{
    public class HOMEController : ControlsController
    {
        public ActionResult Index()
        {
            return View("INDEX");
        }

    }
}