using System;
using System.Collections.Generic;
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
        }
    }
}
