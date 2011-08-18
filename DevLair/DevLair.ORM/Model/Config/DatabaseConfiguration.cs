using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevLair.ORM.Npgsql;
using NHibernate.Cfg;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace DevLair.ORM.Model.Config
{
    public class DatabaseConfiguration
    {
        private Configuration config;

        public DatabaseConfiguration()
        {
            config = Fluently.Configure().Database(PostgreSQLConfiguration.Standard.ConnectionString(DLConnection.conn.ConnectionString)).BuildConfiguration();
        }
    }
}
