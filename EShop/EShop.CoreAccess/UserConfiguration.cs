using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core;
using System.Data.Entity.ModelConfiguration;

namespace EShop.CoreAccess
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(user => user.UserId);
            Property(user => user.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
