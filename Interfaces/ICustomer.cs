using crud_adonet_sqlserver.Models;

namespace crud_adonet_sqlserver.Interfaces;

public interface ICustomer
{
    public Customer CreateCustomer(Customer customer);
    public Customer UpdateCustomer(Customer customer);
    public bool DeleteCustomer(int id);
    public Customer GetCustomerById(int id);
    public IEnumerable<Customer> GetAllCustomers();    
}