using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EShop.Core;

namespace EShop.CoreAccess
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            HasKey(category => category.CategoryId);
            Property(category => category.CategoryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}