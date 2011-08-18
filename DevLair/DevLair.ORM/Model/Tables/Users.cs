using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevLair.ORM.Model.TablesMap
{
    public class Users : EntityBase
    {
        public virtual int UserId { get; set; }
       
        public virtual string NickName { get; set; }
        
        public virtual string Password { get; set; }
        
        public virtual string MailTo { get; set; }
        
        public virtual byte[] UserPhoto { get; set; }

        public virtual Contacts Contacts { get; set; }

        #region ModifyUsers

        #endregion
    }
}
