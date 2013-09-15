using System;
using System.Collections.Generic;

namespace EShop.Core
{
    public class ShippingDetail
    {
        //<Summary>
        //Fields...
        //</Summary>

        public Guid ShippingDetailId { get; set; }

        public bool IsWere { get; set; }// is completed

        public bool IsDelay { get; set; }

        public string HomeNumber { get; set; }

        public string Building { get; set; }

        public string Street { get; set; }

        public string Region { get; set; }

        public string City { get; set; }

        // Fields for relationships
        //public Guid OrderId { get; set; }
        //public Order Order { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        //public Guid UserId { get; set; }
        //public User User { get; set; }


    }
}