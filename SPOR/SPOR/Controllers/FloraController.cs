using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPOR.Controllers
{
    public class FloraController : Controller
    {
        // GET: Flora
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tillandsia()
        {
            return View();
        }
    }
}