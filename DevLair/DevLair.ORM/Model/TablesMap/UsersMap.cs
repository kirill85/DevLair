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
            Id(x => x.UID).GeneratedBy.Sequence("users_userid_seq");
            Map(x => x.NickName).Not.Nullable();
            Map(x => x.Password).Not.Nullable();
            Map(x => x.MailTo).Not.Nullable();
            Map(x => x.UserPhoto);
            HasMany(x => x.Contacts).Cascade.Delete();
  //          References<Contacts>(x => x.Contacts).Cascade.Delete().Cascade.SaveUpdate().Not.Nullable();
        }
    }
}
