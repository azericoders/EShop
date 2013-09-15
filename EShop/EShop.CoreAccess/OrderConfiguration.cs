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
            //HasKey(order => order.ShippingDetailId);
            Property(order => order.OrderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}