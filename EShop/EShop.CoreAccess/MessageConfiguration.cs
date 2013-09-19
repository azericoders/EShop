using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core;

namespace EShop.CoreAccess
{
    public class MessageConfiguration : EntityTypeConfiguration<Message>
    {
        public MessageConfiguration()
        {
            this.HasKey(message => message.MessageId);
            this.Property(message => message.MessageId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
