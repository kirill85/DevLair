using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevLair.ORM.Model.TablesMap
{
    public class Contacts : EntityBase
    {
        public virtual string Icq { get; set; }
        public virtual string Jid { get; set; }
        public virtual string VisibleMail { get; set; }
        public virtual string Msn { get; set; }
    }
}
