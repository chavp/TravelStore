using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelStoreMockupWeb.Controllers
{
    public class OperationController : Controller
    {
        //
        // GET: /Operation/
        public ActionResult Products()
        {
            ViewBag.DataAdminicaNavTop = 1;
            ViewBag.DataAdminicaSideTop = 1;
            return View();
        }

        public ActionResult Agents()
        {
            ViewBag.DataAdminicaNavTop = 2;
            ViewBag.DataAdminicaSideTop = 1;
            return View();
        }
    }
}
