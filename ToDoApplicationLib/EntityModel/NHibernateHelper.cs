﻿using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Conventions.Helpers;
using NHibernate;

namespace ToDoApplicationLib.EntityModel
{
    public sealed class NHibernateHelper
    {

        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    CreateSessionFactory();
                return _sessionFactory;
            }
        }


        private static ISessionFactory CreateSessionFactory()
        {


            _sessionFactory = Fluently.Configure()
                 .Database(FluentNHibernate.Cfg.Db.MsSqlCeConfiguration.Standard.ShowSql()
                 .ConnectionString(c => c.FromConnectionStringWithKey("DbConnectionString")))
                 .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Task.TaskMap>().Conventions.Add(DefaultCascade.All()))
                 .Mappings(m => m.FluentMappings.AddFromAssemblyOf<User.UserMap>().Conventions.Add(DefaultCascade.All()))
                 .Mappings(m => m.FluentMappings.AddFromAssemblyOf<TaskCategory.TaskCategoryMap>().Conventions.Add(DefaultCascade.All()))
                 .BuildSessionFactory();


            return _sessionFactory;
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
