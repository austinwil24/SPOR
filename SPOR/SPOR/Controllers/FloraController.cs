using SPOR.Models;
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
            return View(new GenericPageModel("Flora"));
        }

        public ActionResult Tillandsia()
        {
            return View(new GenericPageModel("Tillandsia Collection"));
        }

        public ActionResult Bonsai()
        {
            return View(new GenericPageModel("Bonsai"));
        }
    }
}