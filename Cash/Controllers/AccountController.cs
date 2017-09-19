using System.Web.Mvc;
using Cash.Models;
using Cash.Repositories;
using NHibernate;

namespace Cash.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(string title)
        {

            // Сохранение данных в БД
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                var newAccount = new Account
                {
                    Title = title
                };

                session.Save(newAccount);
                transaction.Commit();
            }

            // Чтение данных из БД
            var allAccounts = NHibernateHelper
                .OpenSession()
                .QueryOver<Account>()
                .List<Account>();

            return View("List", allAccounts);
        }
    }
}