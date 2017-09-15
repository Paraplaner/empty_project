using System.Web.Mvc;

namespace Cash.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("paraplaner cash webapp");
        }
    }
}
