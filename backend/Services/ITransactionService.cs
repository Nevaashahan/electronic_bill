using BillingSystem.Models;

namespace BillingSystem.Services;

public interface ITransactionService
{
    void AddTransaction(Transaction transaction);
    void UpdateTransaction(int id, Transaction transaction);
    void DeleteTransaction(int id);
    Transaction GetTransaction(int id);
    List<Transaction> GetTransactions();
    List<Transaction> GetTransactions(String search);
    List<Transaction> GetTransactionsByCustomer(String NIC);
    List<Transaction> GetTransactionsByDate(DateTime date);
    List<Transaction> GetTransactionsByInvoice(int invoiceId);
}