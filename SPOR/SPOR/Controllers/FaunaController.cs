using SPOR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SPOR.Utilities;

namespace SPOR.Controllers
{
    public class FaunaController : Controller
    {
        // GET: Fauna
        public ActionResult Index()
        {
            return View(new GenericPageModel("Fauna"));
        }

        public ActionResult PhotoCollection(string source)
        {
            return View(IO.GetFolderFilePaths(string.Format("Content/fauna/{0}", source)));
        }
    }

    public class PhotoCollection
    {
        public string Title { get; set; }

        public ICollection<string> ImagePaths { get; set; }
    }
}