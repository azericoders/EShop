using System;

namespace EShop.Core
{
    public class OrderLine
    {
        //<Summary>
        //Fields...
        //</Summary>

        public Guid OrderLineId { get; set; }

        public bool IsWere { get; set; }// is completed

        public bool IsDelay { get; set; }

        public string HomeNumber { get; set; }

        public string Building { get; set; }

        public string Street { get; set; }

        public string Region { get; set; }

        public string City { get; set; }
        
        // Fields for relationships
        public Guid OrderId { get; set; }
        public Order Order { get; set; }


    }
}