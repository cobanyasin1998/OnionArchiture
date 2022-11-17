using OnionArchiture.Domain.Common;
using System;

namespace OnionArchiture.Domain.Entities
{
    public class Product : BaseEntity
    {
        public String Name { get; set; }
        public Decimal Value { get; set; }
        public int Quantity { get; set; }
    }
}
