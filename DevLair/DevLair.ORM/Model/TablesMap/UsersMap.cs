using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace DevLair.ORM.Model.TablesMap
{
    public class UsersMap : ClassMap<Users>
    {
        public UsersMap()
        {
            Id(x => x.UID).GeneratedBy.Native();
            Map(x => x.NickName).Not.Nullable();
            Map(x => x.Password).Not.Nullable();
            Map(x => x.MailTo).Not.Nullable();
            Map(x => x.UserPhoto);
            References<Contacts>(x => x.Contact).Cascade.Delete().Cascade.SaveUpdate().Not.Nullable();
        }
    }
}
