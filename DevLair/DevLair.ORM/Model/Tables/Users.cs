﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using DevLair.ORM.Npgsql;

namespace DevLair.ORM.Model.Tables
{
    [Table(Name = "Users")]
    public class Users
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ClientId { get; set; }
        [Column(Name = "nick")]
        public string NickName { get; set; }
        [Column(Name = "passwd", CanBeNull = false)]
        public string Password { get; set; }
        [Column(Name = "email", CanBeNull = false)]
        public string MailTo { get; set; }
        [Column(Name = "photo")]
        public byte[] UserPhoto { get; set; }

        #region ModifyUsers

        #endregion
    }
}
