using System.Data.Entity.ModelConfiguration;
using EShop.Core;

namespace EShop.CoreAccess
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(product => product.ProductId);
        }
    }
}