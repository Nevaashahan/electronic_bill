using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BillingSystem.DataContext
{
    public class BillingSystemContext : DbContext
    {
        public BillingSystemContext(DbContextOptions<BillingSystemContext> options) : base(options)
        {
        }

        public DbSet<Models.Customer> Customers { get; set; }
        public DbSet<Models.Invoice> Invoices { get; set; }
        public DbSet<Models.Transaction> Transactions { get; set; }
        public DbSet<Models.CreditBalance> CreditBalances { get; set; }

    }
}
