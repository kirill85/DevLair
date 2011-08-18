using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace DevLair.ORM.Model.TablesMap
{
    public class ContactsMap : ClassMap<Contacts>
    {
        public ContactsMap()
        {
            Id(x => x.UID).GeneratedBy.Guid();
            Map(x => x.Icq);
            Map(x => x.Jid);
            Map(x => x.VisibleMail);
            Map(x => x.Msn);
        }
    }
}
