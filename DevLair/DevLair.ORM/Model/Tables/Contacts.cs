using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace DevLair.ORM.Model.Tables
{
    [Association(IsForeignKey = true)]
    [Table(Name = "contacts")]
    public class Contacts
    {

    }
}
