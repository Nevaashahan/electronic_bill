using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingSystem.DataContext;
using BillingSystem.Models;

namespace BillingSystem.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly BillingSystemContext _context;
        
        public TransactionService(BillingSystemContext context)
        {
            _context = context;
        }
        public void AddTransaction(Transaction transaction)
        {
            try
            {
                _context.Transactions.Add(transaction);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void UpdateTransaction(int id, Transaction transaction)
        {
            try
            {
                var _transaction = _context.Transactions.Find(id);
                _transaction = transaction;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void DeleteTransaction(int id)
        {
            try
            {
                var transaction = _context.Transactions.Find(id);
                _context.Transactions.Remove(transaction);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Transaction GetTransaction(int id)
        {
            try
            {
                var transaction = _context.Transactions.Find(id);
                return transaction;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<Transaction> GetTransactions()
        {
            try
            {
                var transactions = _context.Transactions.ToList();
                return transactions;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<Transaction> GetTransactions(string search)
        {
            try
            {
                var transactions = _context.Transactions.Where(t => t.Customer.NIC.Contains(search) || t.Customer.Name.Contains(search)).ToList();
                return transactions;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<Transaction> GetTransactionsByCustomer(string NIC)
        {
            try
            {
                var transactions = _context.Transactions.Where(t => t.Customer.NIC == NIC).ToList();
                return transactions;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<Transaction> GetTransactionsByDate(DateTime date)
        {
            try
            {
                var transactions = _context.Transactions.Where(t => t.DateTime.Date == date.Date).ToList();
                return transactions;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<Transaction> GetTransactionsByInvoice(int invoiceId)
        {
            try
            {
                var transactions = _context.Transactions.Where(t => t.Invoice.InvoiceId == invoiceId).ToList();
                return transactions;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
