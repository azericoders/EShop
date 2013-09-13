using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EShop.Core;

namespace EShop.CoreAccess
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasKey(order => order.OrderId);
            Property(order => order.OrderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}