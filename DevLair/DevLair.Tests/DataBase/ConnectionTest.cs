using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Data;
using Npgsql;
using nCrypto;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace DevLair.Tests.DataBase
{
    [TestClass]
    public class ConnectionTest
    {
        private Configuration config;
        [TestMethod]
        public void Connect()
        {
            Encrypter encrypter = new Encrypter("64bit");

            String keyword = encrypter.Decrypt("QnV0IHlvdSBkb24ndCByZWFsbHkgbWVhbiBpdA==");

            // Check if crypter is changed
            Assert.AreEqual(true, encrypter.SetCrypter("AES"));

            String connection = encrypter.Decrypt
                ("Sf+ulELX4tNuvsQtUG2EZWPJDPhm8obnrSyEm7F5mtg/eziYSjoIZndeCHk8iZOhvAuMNJBxiiatrRHTt2LVFv/vJNoo8yCHkOO7TwUWv3+l8+Wpis4TSsEvc8zHgEPIucH/OQ2tyYlMboyoFH26dZLZ2Y+Kevfu79VfqLBcKGE=", keyword);

            config = Fluently.Configure().Database(PostgreSQLConfiguration.Standard.ConnectionString(connection)).BuildConfiguration();
            Assert.IsNotNull(config);
        }
    }
}
