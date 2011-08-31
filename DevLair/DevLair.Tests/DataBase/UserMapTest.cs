using System;

using NHibernate;
using FluentNHibernate.Testing;
using FluentNHibernate.Mapping;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevLair.ORM.Model.Config;
using DevLair.ORM.Model.Entities;
using FluentNHibernate;
/*<<<<<<< HEAD
using NHibernate;
using FluentNHibernate;
=======


>>>>>>> 481488fd52dcec153bd17a791082ed78469ed291*/
//using NUnit.Framework;

namespace DevLair.Tests.DataBase
{
    [TestClass]
    public class UserMapTest
    {
        private ISessionFactory session = null;
        [TestMethod]
        [TestInitialize]
        public void UserMapTestInitialize()
        {
            testConfig = new DatabaseConfiguration();
            session = testConfig.FluentCfg.BuildSessionFactory();
            Assert.IsNotNull(testConfig);
        }

        private DatabaseConfiguration testConfig;

        [TestMethod]
        public void testForSession()
        {
            Assert.IsNotNull(session);
        }

        [TestMethod]
        public void testUserSchema()
        {
            Assert.IsNotNull(testConfig.FluentCfg.BuildSessionFactory());
            Users userFoo = new Users();
            var spec = new PersistenceSpecification<Users>
                (session.OpenSession()).CheckProperty(ch => ch.UserId, 1)
                    .CheckProperty(ch => ch.NickName, "JonhDoe")
                    .CheckProperty(ch => ch.Password, "secret")
                    .CheckProperty(ch => ch.MailTo, "jonh@doe.usr")
                    .CheckProperty(ch => ch.UserPhoto, null)
                    .VerifyTheMappings();

            Assert.IsNotNull(spec);
        }

        [TestMethod]
        [TestCleanup]
        public void clearSession()
        {
            session.Close();
            session.Dispose();
        }
    }
}
