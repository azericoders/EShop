using System;

namespace EShop.Core
{
    public class Message
    {
        public Message()
        {
            this.IsDelete = false;
        }

        //<Summary>
        //Fields...
        //</Summary>
        public Guid MessageId { get; set; }

        public string Content { get; set; }

        public DateTime DeliveredDate { get; set; }

        public bool IsDelete { get; set; }

        // Fields for relationships
        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}