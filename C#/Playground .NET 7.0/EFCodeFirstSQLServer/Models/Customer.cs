using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstSQLServer.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        [MaxLength(144)]
        public string Mobile { get; set; }

        public ICollection<Order> Orders { get; set; } = null!;
    }
}