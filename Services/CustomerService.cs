using BillingSystem.DataContext;
using BillingSystem.Models;

namespace BillingSystem.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly BillingSystemContext _db;

        public CustomerService(BillingSystemContext context)
        {
            _db = context;
        }
        void AddCustomer(Customer customer)
        {
            _db.Add(customer);
            _db.SaveChanges();
        }

        void ICustomerService.AddCustomer(Customer customer)
        {
            AddCustomer(customer);
        }

        public void UpdateCustomer(String NIC, Customer customer)
        {
            var _customer = _db.Customers.Find(NIC);
            _customer = customer;
            _db.SaveChanges();
        }

        public void DeleteCustomer(String NIC)
        {
            var customer = _db.Set<Customer>().Find(NIC);
            _db.Remove(customer);
            _db.SaveChanges();
        }

        public Customer GetCustomer(string NIC)
        {
            var customer = _db.Customers.Find(NIC);
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            var customers = _db.Customers.ToList();
            return customers;
        }

        public List<Customer> GetCustomers(string search)
        {
            var customers = _db.Customers.Where(c => c.Name.Contains(search) || c.NIC.Contains(search)).ToList();
            return customers;
        }

        public Customer GetCustomerByPhone(string phone)
        {
            var customer = _db.Customers.Where(c => c.Phone == phone).FirstOrDefault();
            return customer;
        }
    }
}
