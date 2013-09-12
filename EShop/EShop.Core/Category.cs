using System;

namespace EShop.Core
{
    public class Category
    {
        //<Summary>
        //Fields...
        //</Summary>

        public Guid CategoryId { get; set; }

        public string CategoryName { get; set; }


        // Fields for relationships
        public Guid MainCategoryId { get; set; }
        public virtual Category MainCategory { get; set; }
    }
}