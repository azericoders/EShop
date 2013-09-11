using System;

namespace EShop.Core
{
    public class Product
    {
        //<Summary>
        //Fields...
        //</Summary>
        public Guid ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }


        // Fields for relationships
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }

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