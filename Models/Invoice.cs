using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Lombok.NET;

namespace BillingSystem.Models
{
    [RequiredArgsConstructor]
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public double Total { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public double Discount { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public double NetTotal { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public double Paid { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public double Balance { get; set; }
        public string? Description { get; set; }
        public DateTime DateTime { get; set; }

        [ForeignKey("NIC")]
        public Customer Customer { get; set; }
        [ForeignKey("TransactionId")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}