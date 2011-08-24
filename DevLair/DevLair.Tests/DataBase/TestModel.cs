using System;
using System.Collections.Generic;
using FluentNHibernate;
using DevLair.ORM.Model.TablesMap;

namespace DevLair.Tests.DataBase
{
    public class TestModel : PersistenceModel
    {
        public TestModel()
        {
            AddMappingsFromAssembly(typeof(UsersMap).Assembly);
        }
    }
}
