using System.ComponentModel.DataAnnotations;

namespace HardWareApplication.Entity
{
    public class UserAccounts
    {
        [Key]
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
    }
}
