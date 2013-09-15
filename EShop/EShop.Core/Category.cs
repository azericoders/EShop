using System;
using System.Collections.Generic;

namespace EShop.Core
{
    public class Category
    {
        //<Summary>
        //Fields...
        //</Summary>

        public Guid CategoryId { get; set; }

        public string CategoryName { get; set; }

        public bool IsDelete { get; set; }
        // Fields for relationships
        public Guid MainCategoryId { get; set; }
        public Category MainCategory { get; set; }

        public virtual ICollection<Category> ChildCategories { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}