using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BillingSystem.Models
{
    public class Customer
    {
        [Key]
        private string NIC { get; set; }
        private string Name { get; set; }
        private string Address { get; set; }
        private string Phone { get; set; }
        private string Email { get; set; }
        private string Discription { get; set; }
        private int NoOfOrders { get; set; }
        public CreditBalance CreditBalance { get; set; }
        public virtual ICollection<Transaction> Transections { get; set; }
    }
}
