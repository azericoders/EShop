using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core;

namespace EShop.CoreAccess
{
    public class EShopDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new CompanyConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrderLineConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new MessageConfiguration());
        }
    }
}
