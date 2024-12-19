using System;
using Annies_Cat_Sanctuary.Data;

namespace Annies_Cat_Sanctuary.Models
{
    public class Message
    {
        public int MessageId { get; set; } // Primary Key
        public string SenderId { get; set; } // Foreign Key for Sender
        public string RecipientId { get; set; } // Foreign Key for Recipient
        public string MessageText { get; set; } // The message content
        public DateTime Timestamp { get; set; } // When the message was sent
        public bool IsRead { get; set; } // Whether the message has been read

        // Navigation properties
        public ApplicationUser Sender { get; set; }
        public ApplicationUser Recipient { get; set; }
    }
}
