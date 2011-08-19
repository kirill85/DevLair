using System;
using System.Collections.Generic;

namespace DevLair.ORM.Model.TablesMap
{
    public class Contacts : EntityBase
    {
        public Contacts()
        {
            Users = new List<Users>();
        }

        public virtual int ContactId { get; protected set; }
        
        public virtual string Icq { get; set; }
        
        public virtual string Jid { get; set; }
        
        public virtual string VisibleMail { get; set; }
        
        public virtual string Msn { get; set; }

        public IList<Users> Users { get; protected set; }
    }
}
