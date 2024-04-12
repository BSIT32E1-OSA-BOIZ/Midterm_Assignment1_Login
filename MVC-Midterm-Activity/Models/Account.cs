using System.ComponentModel.DataAnnotations;

namespace MVC_Midterm_Activity.Models
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Salt { get; set; }
        public string EmailAddress { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    }
}
