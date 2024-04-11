using BillingSystem.DataContext;
using BillingSystem.Models;

namespace BillingSystem.Services;

public class InvoiceService: IInvoiceService
{
    private readonly BillingSystemContext _db;
    
    public InvoiceService(BillingSystemContext context)
    {
        _db = context;
    }
    
    public Invoice CreateInvoice(Invoice invoice)
    {
        try
        {
            _db.Invoices.Add(invoice);
            _db.SaveChanges();
            return invoice;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    // Wanted to correct and check the logic of this method
    public Invoice CreateInvoiceWithTransaction(List<Transaction> transaction)
    {
        try
        {
            var invoice = new Invoice();
            invoice.Transactions = transaction;
            invoice.Total = transaction.Sum(t => t.Total);
            invoice.Customer = transaction[0].Customer;
            _db.Invoices.Add(invoice);
            _db.SaveChanges();
            return invoice;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    public Invoice UpdateInvoice(int id, Invoice invoice)
    {
        try
        {
            var _invoice = _db.Invoices.Find(id);
            _invoice = invoice;
            _db.SaveChanges();
            return invoice;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void DeleteInvoice(int id)
    {
        try
        {
            var invoice = _db.Invoices.Find(id);
            _db.Invoices.Remove(invoice);
            _db.SaveChanges();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Invoice GetInvoice(int id)
    {
        try
        {
            var invoice = _db.Invoices.Find(id);
            return invoice;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Invoice> GetInvoices()
    {
        try
        {
            var invoices = _db.Invoices.ToList();
            return invoices;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Invoice> GetInvoices(string search)
    {
        try
        {
            var invoices = _db.Invoices.Where(i => i.Customer.Name.Contains(search) || i.Customer.NIC.Contains(search)).ToList();
            return invoices;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Invoice> GetInvoicesByCustomer(string NIC)
    {
        try
        {
            var invoices = _db.Invoices.Where(i => i.Customer.NIC == NIC).OrderBy(i => i.DateTime).ToList();
            return invoices;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Invoice> GetInvoicesByDate(DateTime date)
    {
        try
        {
            var invoices = _db.Invoices.Where(i => i.DateTime.Date == date.Date).ToList();
            return invoices;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Invoice> GetInvoicesByTransaction(int transactionId)
    {
        try
        {
            var invoices = _db.Invoices.Where(i => i.Transactions.Any(t => t.TransactionId == transactionId)).ToList();
            return invoices;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void PrintInvoice(int id)
    {
        throw new NotImplementedException();
    }

    public void PdfInvoice(int id)
    {
        throw new NotImplementedException();
    }
}