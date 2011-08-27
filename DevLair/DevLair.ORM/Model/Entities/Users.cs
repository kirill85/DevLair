using System;
using System.Collections.Generic;

namespace DevLair.ORM.Model.Entities
{
    public class Users
    {
        public Users()
        {
            Contacts = new List<Contacts>();
        }
        public virtual int UserId { get; private set; }
       
        public virtual string NickName { get; set; }
        
        public virtual string Password { get; set; }
        
        public virtual string MailTo { get; set; }
        
        public virtual byte[] UserPhoto { get; set; }

        public virtual IList<Contacts> Contacts { get; set; }

        #region ModifyUsers

        #endregion
    }
}
