using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;

namespace DevLair.ORM.Model.Entities
{
    public class UsersMap : ClassMap<Users>
    {
        public UsersMap()
        {
//<<<<<<< HEAD
//            Id(x => x.UserId).Column("userid").CustomSqlType//("Serial").GeneratedBy.Native();
//=======
            Table("Users"); // Not sure ???
            Id(x => x.UserId).Column("userid").GeneratedBy.Sequence("users_userid_seq");
//>>>>>>> 481488fd52dcec153bd17a791082ed78469ed291
            Map(x => x.NickName).Column("nickname").Not.Nullable();
            Map(x => x.Password).Column("passwd").Not.Nullable();
            Map(x => x.MailTo).Column("email").Not.Nullable();
            Map(x => x.UserPhoto).Column("userphoto");
            HasMany(x => x.Contacts).Cascade.Delete().Table("users");
  //          References<Contacts>(x => x.Contacts).Cascade.Delete().Cascade.SaveUpdate().Not.Nullable();
        }
    }
}
