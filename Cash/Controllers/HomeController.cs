using System.Web.Mvc;

namespace Cash.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Просмотр списка записей.
        /// </summary>
        public ActionResult List()
        {
            return View();
        }
    }
}
