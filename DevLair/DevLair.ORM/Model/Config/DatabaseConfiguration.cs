using System;
using System.Collections.Generic;
using DevLair.ORM.Npgsql;
using nCrypto;
using DevLair.ORM.Model.Entities;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate;

namespace DevLair.ORM.Model.Config
{
    public class DatabaseConfiguration
    {
        private string connectionString = "";
        private ISessionFactory session = null;
        private Configuration config = null;
        private FluentConfiguration fluentCfg = null;

        public ISessionFactory Session
        {
            get
            {
                session = fluentCfg.BuildSessionFactory();
                return session;
            }
        }

        public DatabaseConfiguration()
        {
            Encrypter encrypter = new Encrypter("64bit");
            string keyword = encrypter.Decrypt("QnV0IHlvdSBkb24ndCByZWFsbHkgbWVhbiBpdA==");
            encrypter.SetCrypter("AES");
            this.connectionString = encrypter.Decrypt("Sf+ulELX4tNuvsQtUG2EZWPJDPhm8obnrSyEm7F5mtg/eziYSjoIZndeCHk8iZOhvAuMNJBxiiatrRHTt2LVFv/vJNoo8yCHkOO7TwUWv3+l8+Wpis4TSsEvc8zHgEPIucH/OQ2tyYlMboyoFH26dZLZ2Y+Kevfu79VfqLBcKGE=", keyword);
            fluentCfg = Fluently.Configure().Database(PostgreSQLConfiguration.Standard.ConnectionString(this.connectionString)).Mappings(m =>
            {
                m.HbmMappings.AddFromAssemblyOf<Users>();
                m.HbmMappings.AddFromAssemblyOf<Contacts>();
            });
            config = fluentCfg.BuildConfiguration();
        }
    }
}
