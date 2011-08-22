using System;
using System.Collections.Generic;

namespace DevLair.ORM.Model.TablesMap
{
    public class Contacts : EntityBase
    {
        public virtual int ContactId { get; private set; }
        
        public virtual string Icq { get; set; }
        
        public virtual string Jid { get; set; }
        
        public virtual string VisibleMail { get; set; }
        
        public virtual string Msn { get; set; }

        public Users Users { get; private set; }
    }
}
