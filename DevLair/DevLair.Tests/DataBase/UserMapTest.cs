using System;

using NHibernate;
using FluentNHibernate.Testing;
using FluentNHibernate.Mapping;

using DevLair.ORM.Model.Config;
using DevLair.ORM.Model.Entities;
<<<<<<< HEAD
using NHibernate;
using FluentNHibernate;
=======

using Microsoft.VisualStudio.TestTools.UnitTesting;
>>>>>>> 481488fd52dcec153bd17a791082ed78469ed291
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

<<<<<<< HEAD
            var spec = new PersistenceSpecification<Users>((ISessionSource)testConfig.Session).CheckProperty(ch => ch.UserId, 1).CheckProperty(ch => ch.NickName, "JonhDoe").CheckProperty(ch => ch.Password, "secret").CheckProperty(ch => ch.MailTo, "jonh@doe.usr").CheckProperty(ch => ch.UserPhoto, null).VerifyTheMappings();
=======
            var spec = new PersistenceSpecification<Users>
                (testConfig.Session).CheckProperty(ch => ch.UserId, 1)
                    .CheckProperty(ch => ch.NickName, "JonhDoe")
                    .CheckProperty(ch => ch.Password, "secret")
                    .CheckProperty(ch => ch.MailTo, "jonh@doe.usr")
                    .CheckProperty(ch => ch.UserPhoto, null)
                    .VerifyTheMappings();
>>>>>>> 481488fd52dcec153bd17a791082ed78469ed291

            Assert.IsNotNull(spec);
        }
    }
}
