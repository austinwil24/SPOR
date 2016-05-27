using SPOR.Models;
using System.Web.Mvc;

namespace SPOR.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Index()
        {
            return View(new GenericPageModel("Games"));
        }

        public ActionResult OceanOnslaught()
        {
            return View(new GenericPageModel("Ocean Onslaught"));
        }
    }
}