using BillingSystem.Models;

namespace BillingSystem.Services;

public interface ICustomerService
{
    void AddCustomer(Customer customer);
    void UpdateCustomer(String NIC, Customer customer);
    void DeleteCustomer(String NIC);
    Customer GetCustomer(String NIC);
    List<Customer> GetCustomers();
    List<Customer> GetCustomers(String search);
    Customer GetCustomerByPhone(String phone);
}