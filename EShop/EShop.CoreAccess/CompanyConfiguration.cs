using System.Data.Entity.ModelConfiguration;
using EShop.Core;

namespace EShop.CoreAccess
{
    public class CompanyConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            HasKey(company => company.CompanyId);
        }
    }
}