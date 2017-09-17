using System.Web.Mvc;

namespace Cash.Controllers
{
    public class StatisticsController: Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Print()
        {
            return Content("Печать не реализована!");
        }
    }
}