using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevLair.ORM.Model.Config;
using FluentNHibernate.Testing;
using DevLair.ORM.Model.Entities;
using NHibernate;

namespace DevLair.Tests.DataBase
{
    [TestClass]
    public class UserMapTest
    {
        private Users usersSpec;

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
            try
            {
                usersSpec = new PersistenceSpecification<Users>(testConfig.Session).CheckProperty(ch => ch.UserId, 0).CheckProperty(ch => ch.NickName, "JonhDoe").CheckProperty(ch => ch.Password, "Doe").CheckProperty(ch => ch.MailTo, "jonh@doe.usr").CheckProperty(ch => ch.UserPhoto, null).CheckProperty(ch => ch.Contacts, null).VerifyTheMappings();
                Assert.IsNotNull(usersSpec);
            }
            catch (MappingException exc)
            {
                Console.WriteLine(exc.Source);
            }
        }
    }
}
