using Microsoft.EntityFrameworkCore;

namespace BillingSystem.DataContext
{
    public class BillingSystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=/DataContext/Databases/billingSystem.db");
        }

        public DbSet<Models.Customer> Customers { get; set; }
        public DbSet<Models.Invoice> Invoices { get; set; }
        public DbSet<Models.Transaction> Transactions { get; set; }
        public DbSet<Models.CreditBalance> CreditBalances { get; set; }
    }
}
