using System.Data.SQLite;
using System.Web.Mvc;
using System.Web.Routing;
using Cash.Models;
using Cash.Repositories;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Cash
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Создаем новую базу данных (файл должен совпадать с файлом в hibernate.cfg.xml).
            SQLiteConnection.CreateFile("d:/cash-database.sqlite3.db");

            // Конфигурация ORM
            var cfg = new Configuration();
            cfg.Configure();

            cfg.AddAssembly(typeof(Account).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);

            NHibernateHelper.Init(cfg);

            // Конфигурация ASP.NET MVC
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
