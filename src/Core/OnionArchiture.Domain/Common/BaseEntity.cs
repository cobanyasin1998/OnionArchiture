using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchiture.Domain.Common
{
   public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedTime { get; set; }

    }
}
