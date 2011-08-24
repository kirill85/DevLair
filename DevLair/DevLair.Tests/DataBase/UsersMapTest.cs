using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using DevLair.ORM.Model.TablesMap;
using FluentNHibernate.Testing;

namespace DevLair.Tests.DataBase
{
    [TestFixture]
    public class UsersMapTest : TestBase
    {
        [Test]
        public void CanCorrectUsersMap()
        {
            new PersistenceSpecification<Users>(Session).CheckProperty(c => c.UserId, 1).CheckProperty(c => c.NickName, "MaryJane").CheckProperty(c => c.MailTo, "mary@jane.com").CheckProperty(c => c.Password, "secret").CheckProperty(c => c.Contacts, null).CheckProperty(c => c.UserPhoto, null).VerifyTheMappings();
        }
    }
}
