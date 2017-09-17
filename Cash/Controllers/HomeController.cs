using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using Cash.Models;

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
            IList<CashflowRecord> model = CreateFakeData(); 
            return View(model);
        }

        private IList<CashflowRecord> CreateFakeData()
        {
            var fakeData = new List<CashflowRecord>();
            
            fakeData.Add(new CashflowRecord
            {
                Amount = 1234m,
                DateTime = DateTime.Now,
                Category = new Category { Title = "Провеочная категория" },
                Account = new Account {Title = "Наличные"},
                Comments = "Тестовый комментарий"
            });
            
            return fakeData;
        }
    }
}
