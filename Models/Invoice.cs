using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Models
{
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
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}