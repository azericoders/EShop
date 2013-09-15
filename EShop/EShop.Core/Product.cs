﻿using System;

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

        public string Image { get; set; }

        public string Image2 { get; set; }

        public string Image3 { get; set; }

        public string ThumbnialImage { get; set; }

        public bool IsDelete { get; set; }

        // Fields for relationships
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}