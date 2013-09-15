using System;
using System.Collections.Generic;

namespace EShop.Core
{
    public class Company
    {
        //<Summary>
        //Fields...
        //</Summary>

        public Guid CompanyId { get; set; }

        public string CompanyName { get; set; }

        public string LogoFile { get; set; }

        public bool IsBrand { get; set; }

        public bool IsDelete { get; set; }
        // Fields for relationships
        public virtual ICollection<Product> Products { get; set; }

    }
}