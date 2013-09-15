using System;

namespace EShop.Core
{
    public class OrderLine
    {
        //<Summary>
        //Fields...
        //</Summary>

        public Guid OrderLineId { get; set; }

        public decimal ProductPrice { get; set; }

        // Fields for relationships
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}