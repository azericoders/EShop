using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Core
{
    public class User
    {
        public Guid UserId { get; set; }

        [StringLength(20)]
        public string LoginName { get; set; }

        public string Password { get; set; }

        public Status Status { get; set; }
    }
}
