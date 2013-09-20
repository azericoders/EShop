using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using EShop.Core;

namespace EShop.CoreAccess
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            HasKey(category => category.CategoryId);
            Property(category => category.CategoryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasOptional(category => category.MainCategory)
                .WithMany(category => category.ChildCategories)
                .HasForeignKey(category => category.MainCategoryId);
        }
    }
}