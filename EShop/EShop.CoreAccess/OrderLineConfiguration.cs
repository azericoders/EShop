using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EShop.Core;

namespace EShop.CoreAccess
{
    public class OrderLineConfiguration : EntityTypeConfiguration<OrderLine>
    {
        public OrderLineConfiguration()
        {
            HasKey(orderline => orderline.OrderLineId);
            Property(orderLine => orderLine.OrderLineId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}