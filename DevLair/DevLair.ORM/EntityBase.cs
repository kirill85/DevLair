using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevLair.ORM
{
    public abstract class EntityBase
    {
        public virtual Guid UID { get; set; }
    }
}
