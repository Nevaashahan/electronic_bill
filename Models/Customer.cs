using System.ComponentModel.DataAnnotations;
using Lombok.NET;

namespace BillingSystem.Models
{
    [RequiredArgsConstructor]
    public partial class Customer
    {
        public Customer(string nic, string name, string? address, string phone, string? email, string? description)
        {
            NIC = nic;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            Description = description;
        }

        [Key]
        [MaxLength(12)]
        public string NIC { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public string? Description { get; set; }
        public int? NoOfOrders { get; set; }
        public CreditBalance CreditBalance { get; set; }
        
        public virtual ICollection<Transaction> Transections { get; set; }
    }
}
