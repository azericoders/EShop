using System;

namespace EShop.Core
{
    public class Order
    {
        //<Summary>
        //Fields...
        //</Summary>
        
        public Guid OrderId { get; set; }

        public DateTime OrderDate { get; set; }


        // Fields for relationships
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}