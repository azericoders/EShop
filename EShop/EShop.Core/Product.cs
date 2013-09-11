using System;

namespace EShop.Core
{
    public class Product
    {
        public Guid ProductId { get; set; }

        public string Name { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
    }
}