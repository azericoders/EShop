using System;
using System.Collections.Generic;

namespace EShop.Core
{
    public class Order
    {
        public Order()
        {
            this.IsWere = false;
            this.IsDelete = false;
        }
        //<Summary>
        //Fields...
        //</Summary>

        public Guid OrderId { get; set; }

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public bool IsWere { get; set; }// is completed

        public decimal TotalAmount { get; set; }

        public ShippingDetail ShippingDetail { get; set; }

        public bool IsDelete { get; set; }
        // Fields for relationships

        public Guid UserId { get; set; }
        public User User { get; set; }

        //public Guid ShippingDetailId { get; set; }
        //public ShippingDetail ShippingDetail { get; set; }

        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}