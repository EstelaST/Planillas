using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planillas.Controllers
{
    public class ControlsController : Controller
    {
        public DBPlanillasDataContext db = new DBPlanillasDataContext();
        public enum opcion
        {
            Add = 1,
            Update = 2,
            Delete = 3
        }
    }
}