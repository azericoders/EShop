using System;
using System.Collections.Generic;

namespace EShop.Core
{
    public class Product
    {
        public Product()
        {
            AddingDate = DateTime.Now;
        }
        //<Summary>
        //Fields...
        //</Summary>

        public Guid ProductId { get; set; }

        public string ProductNumber { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Count { get; set; }

        public int SoldCount { get; set; }

        public int RestCount { get; set; }

        public int Returned { get; set; }

        public decimal Price { get; set; }

        public decimal PriceOfBuying { get; set; }

        public string ThumbnailPhoto { get; set; }

        public string ProductInfo { get; set; }

        public DateTime AddingDate { get; set; }

        public bool IsDelete { get; set; }

        // Fields for relationships
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public virtual ICollection<OrderLine> OrderLines { get; set; }

        public virtual ICollection<ProductPhoto> ProductPhotos { get; set; }
    }
}