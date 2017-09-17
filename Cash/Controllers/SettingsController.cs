using System.Web.Mvc;

namespace Cash.Controllers
{
    /// <summary>
    /// Настройки.
    /// </summary>
    public class SettingsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}