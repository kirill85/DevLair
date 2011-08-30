using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevLair.ORM.Model.Config;
using FluentNHibernate.Testing;
using DevLair.ORM.Model.Entities;
using NHibernate;
//using NUnit.Framework;

namespace DevLair.Tests.DataBase
{
    [TestClass]
    public class UserMapTest
    {
        [TestMethod]
        [TestInitialize]
        public void UserMapTestInitialize()
        {
            testConfig = new DatabaseConfiguration();
            Assert.IsNotNull(testConfig);
        }

        private DatabaseConfiguration testConfig;

        [TestMethod]
        public void testForSession()
        {
            Assert.IsNotNull(testConfig.Session);
        }

        [TestMethod]
        public void testUserSchema()
        {
            Assert.IsNotNull(testConfig.Session);

            var spec = new PersistenceSpecification<Users>
                (testConfig.Session).CheckProperty(ch => ch.UserId, 1)
                    .CheckProperty(ch => ch.NickName, "JonhDoe")
                    .CheckProperty(ch => ch.Password, "secret")
                    .CheckProperty(ch => ch.MailTo, "jonh@doe.usr")
                    .CheckProperty(ch => ch.UserPhoto, null)
                    .VerifyTheMappings();

            Assert.IsNotNull(spec);
        }
    }
}
