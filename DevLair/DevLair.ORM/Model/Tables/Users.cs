using System;
using System.Collections.Generic;

namespace DevLair.ORM.Model.TablesMap
{
    public class Users : EntityBase
    {
        public virtual int UserId { get; protected set; }
       
        public virtual string NickName { get; set; }
        
        public virtual string Password { get; set; }
        
        public virtual string MailTo { get; set; }
        
        public virtual byte[] UserPhoto { get; set; }

        public virtual Contacts Contact { get; set; }

        #region ModifyUsers

        #endregion
    }
}
