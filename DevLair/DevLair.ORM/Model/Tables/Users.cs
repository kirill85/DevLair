using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using NpgsqlTypes;
using Npgsql;

namespace DevLair.ORM.Model.Tables
{
    [Table(Name = "Users")]
    public class Users
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int clientId { get; set; }
        [Column(Name = "nick")]
        public string NickName { get; set; }
        [Column(Name = "passwd", CanBeNull = false)]
        public string Password { get; set; }
        [Column(Name = "email")]
        public string MailTo { get; set; }
        [Column(Name = "photo")]
        public byte[] UserPhoto { get; set; }
    }
}
