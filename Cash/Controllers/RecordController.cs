using System.Web.Mvc;

namespace Cash.Controllers
{
    public class RecordController: Controller
    {
        public ActionResult Add()
        {
            return View(); // Если не указан параметр, имя view совпадает с именем метода (в данном случае - "Add")
        }

        public ActionResult Edit()
        {
            return Content("Не реализовано");
        }

        public ActionResult Delete()
        {
            return Content("Не реализовано");
        }
    }
}