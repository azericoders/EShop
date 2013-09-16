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

        public bool IsDelete { get; set; }

        public int ProductCount { get; set; }

        public decimal TotalAmount { get; set; }
        // Fields for relationships
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}