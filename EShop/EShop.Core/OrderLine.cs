using System;

namespace EShop.Core
{
    public class OrderLine
    {
        //<Summary>
        //Fields...
        //</Summary>

        public Guid OrderLineId { get; set; }

        public DateTime ShippingDate { get; set; }

        public bool Were { get; set; }

        public bool IsDelay { get; set; }

        // Fields for relationships
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}