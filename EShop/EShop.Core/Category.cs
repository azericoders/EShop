using System;

namespace EShop.Core
{
    public class Category
    {
        public Guid CategoryId { get; set; }

        public string CategoryName { get; set; }

        public Guid MainCategoryId { get; set; }

        public Category MainCategory { get; set; }
    }
}