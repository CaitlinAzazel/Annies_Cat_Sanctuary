using Annies_Cat_Sanctuary.Models;
using Microsoft.AspNetCore.Identity;

namespace Annies_Cat_Sanctuary.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        // Navigation properties for messages
        public ICollection<Message> SentMessages { get; set; } = new List<Message>();
        public ICollection<Message> ReceivedMessages { get; set; } = new List<Message>();
    }

}
