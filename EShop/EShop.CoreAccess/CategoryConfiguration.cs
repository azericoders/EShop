using System.Data.Entity.ModelConfiguration;
using EShop.Core;

namespace EShop.CoreAccess
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            HasKey(category => category.CategoryId);
        }
    }
}