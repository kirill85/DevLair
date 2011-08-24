using System;
using System.Collections.Generic;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db; 
using NHibernate;
using NUnit.Framework;

namespace DevLair.Tests.DataBase
{
    public class TestBase
    {
        protected ISessionSource SessionSource { get; set; }
        protected ISession Session { get; private set; }

        [SetUp]
        public void setupContext()
        {
            var cfg = Fluently.Configure().Database(PostgreSQLConfiguration.Standard.ConnectionString(new ConnectionTest().ConnectionString));
            SessionSource = new SessionSource(cfg.BuildConfiguration().Properties, new TestModel());
            Session = SessionSource.CreateSession();
            SessionSource.BuildSchema();
        }

        [TearDown]
        public void tearDownContext()
        {
            Session.Close();
            Session.Dispose();
        }
    }
}
