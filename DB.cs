using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using rpbd2.Entities;
using System.Collections;

namespace rpbd2
{
    public class DB
    {
        private static DB? instance;

        private ISession session;

        private DB()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(
                  PostgreSQLConfiguration.Standard.ConnectionString(connStr => connStr
                    .Host("localhost")
                    .Port(5432)
                    .Database("rpbd2")
                    .Username("m8u")
                    .Password("3369")
                  )
                )
                .Mappings(m =>
                    m.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(config =>
                {
                    new SchemaUpdate(config).Execute(false, true);
                })
                .BuildSessionFactory();
            
            session = sessionFactory.OpenSession();
        }

        public static DB getInstance()
        {
            if (instance == null)
            {
                instance = new DB();
            }
            return instance;
        }

        public T Get<T>(int id)
        {
            return session.Get<T>(id);
        }

        public IList GetAll(string tableName)
        {
            return session.CreateQuery("from " + tableName).List();
        }

        public void Delete(object obj)
        {
            using (var transaction = session.BeginTransaction()) 
            { 
                session.Delete(obj);
                transaction.Commit();
            }
        }

        public void FlushAsync()
        {
            session.FlushAsync();
        }
    }
}
