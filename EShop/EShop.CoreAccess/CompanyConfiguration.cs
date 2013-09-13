using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EShop.Core;

namespace EShop.CoreAccess
{
    public class CompanyConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            HasKey(company => company.CompanyId);
            Property(company => company.CompanyId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}