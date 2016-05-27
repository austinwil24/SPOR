using SPOR.Models;
using System.Web.Mvc;

namespace SPOR.Controllers
{
    public class AboutMeController : Controller
    {
        // GET: AboutMe
        public ActionResult Index()
        {
            return View(new GenericPageModel("About Me"));
        }
    }
}