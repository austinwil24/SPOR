﻿using SPOR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPOR.Controllers
{
    public class OtherController : Controller
    {
        // GET: Other
        public ActionResult Index()
        {
            return View(new GenericPageModel("Other"));
        }
    }
}