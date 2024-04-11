using BillingSystem.Models;

namespace BillingSystem.Services;

public interface IInvoiceService
{
    Invoice CreateInvoice(Invoice invoice);
    Invoice CreateInvoiceWithTransaction(List<Transaction> transaction);
    Invoice UpdateInvoice(int id, Invoice invoice);
    void DeleteInvoice(int id);
    Invoice GetInvoice(int id);
    List<Invoice> GetInvoices();
    List<Invoice> GetInvoices(String search);
    List<Invoice> GetInvoicesByCustomer(String NIC);
    List<Invoice> GetInvoicesByDate(DateTime date);
    List<Invoice> GetInvoicesByTransaction(int transactionId);
    
    void PrintInvoice(int id);
    void PdfInvoice(int id);
}