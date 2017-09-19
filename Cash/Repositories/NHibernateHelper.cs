using System;
using NHibernate;
using NHibernate.Cfg;

namespace Cash.Repositories
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {

            get
            {
                if (_sessionFactory == null)
                {
                    throw new InvalidOperationException("Приложение сконфигурировано некорректно!");
                }
                return _sessionFactory;
            }
        }

        public static void Init(Configuration cfg)
        {
            _sessionFactory = cfg.BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}