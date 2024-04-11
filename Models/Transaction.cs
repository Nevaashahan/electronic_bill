using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models
{
    public class Transaction
    {
        private int TransectionID { get; set; }
        private string NIC { get; set; }
        private DateTime DateTime { get; set; }
        private string Service { get; set; }
        private double Price { get; set; }
        private double Amount { get; set; }
        private double Balance { get; set; }
        private double Total { get; set; }
        private string Discription { get; set; }
        private string PaymentMethod { get; set; }
    }
}
