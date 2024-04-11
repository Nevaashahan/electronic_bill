using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lombok.NET;

namespace BillingSystem.Models
{
    [RequiredArgsConstructor]
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [ForeignKey("Customer")]
        public string NIC { get; set; }
        public DateTime DateTime { get; set; }
        public string Service { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
        [DataType(DataType.Currency)]
        public double Balance { get; set; }
        [DataType(DataType.Currency)]
        public double Total { get; set; }
        public string Description { get; set; }
        public string PaymentMethod { get; set; }
        
        public virtual Customer Customer { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
