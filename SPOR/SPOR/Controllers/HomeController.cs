using SPOR.Models;
using System.Web.Mvc;

namespace SPOR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new GenericPageModel("Austin Wilson") { TitleExtension = "- Software Engineer" });
        }
    }
}