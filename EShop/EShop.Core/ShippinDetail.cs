﻿using System;

namespace EShop.Core
{
    public class ShippinDetail
    {
        //<Summary>
        //Fields...
        //</Summary>

        public Guid ShippingDetailId { get; set; }

        // Fields for relationships
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}