using BillingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BillingSystem.DataContext;

public class ReadOnlyDbContext : DbContext
{
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Invoice> Invoices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Transaction>().ToView("Transactions");
        modelBuilder.Entity<Invoice>().ToView("Invoices");
    }
}