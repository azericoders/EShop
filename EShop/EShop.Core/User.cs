using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EShop.Core
{
    public class User
    {
        //<Summary>
        //Fields...
        //</Summary>

        public Guid UserId { get; set; }

        [StringLength(15)]
        public string LoginName { get; set; }

        [StringLength(255)]
        public string Password { get; set; }

        [StringLength(25)]
        public string Email { get; set; }

        public Position Position { get; set; }
        public StatusEnum Status { get; set; }

        // Fields for relationships
        public virtual ICollection<Order> Orders { get; set; }
    }

    public enum Position
    {
        Simple,
        Admin
    }
}
