using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShop.Web.Models
{
    public class OrderStatusViewModel
    {
        public Guid OrderId { get; set; }
        public bool No { get; set; }
        public bool Yes { get; set; }
    }
}