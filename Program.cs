using crud_adonet_sqlserver.Models;
using crud_adonet_sqlserver.Repositories;

string connectionString = @"Server=LocalHost,1433;Database=Customers;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False;TrustServerCertificate=True;";

var customerRepository = new CustomerRepository(connectionString);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Create Customer");
Console.WriteLine("---------------");

var createCustomerPeterParker = new Customer { Name = "Peter Parker", Email = "peter.parker@marvel.com" };
var createCustomerBenParker = new Customer { Name = "Ben Parker", Email = "ben.parker@marvel.com" };
var createCustomerMaryJane = new Customer { Name = "Mary Jane", Email = "mary.jane@marvel.com" };

var peterParker = customerRepository.CreateCustomer(createCustomerPeterParker);
var benParker = customerRepository.CreateCustomer(createCustomerBenParker);
var maryJane = customerRepository.CreateCustomer(createCustomerMaryJane);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Customer created - { peterParker.Id } - { peterParker.Name } - { peterParker.Email }");
Console.WriteLine($"Customer created - { benParker.Id } - { benParker. Name } - { benParker.Email }");
Console.WriteLine($"Customer created - { maryJane.Id } - { maryJane.Name } - { maryJane.Email }");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Update Customer");
Console.WriteLine("---------------");

var updateCustomerMaryJane = new Customer {Id = maryJane.Id, Name = "Mary Jane Watson", Email = maryJane.Email};
customerRepository.UpdateCustomer(updateCustomerMaryJane);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Customer updated - { updateCustomerMaryJane.Id } - { updateCustomerMaryJane.Name } - { updateCustomerMaryJane.Email }");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Delete Customer");
Console.WriteLine("---------------");

customerRepository.DeleteCustomer(benParker.Id);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Customer deleted - { benParker.Id } - { benParker.Name } - { benParker.Email }");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Get Customer");
Console.WriteLine("------------");
Console.ForegroundColor = ConsoleColor.Magenta;

var customerByIdReturned = customerRepository.GetCustomerById(peterParker.Id);
if (customerByIdReturned is not null) Console.WriteLine($"Returned customer - { customerByIdReturned.Id } - { customerByIdReturned.Name } - { customerByIdReturned.Email }");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Get All Customers");
Console.WriteLine("-----------------");
Console.ForegroundColor = ConsoleColor.Magenta;

var allReturnedCustomers = customerRepository.GetAllCustomers();

foreach (var currentCustomer in allReturnedCustomers)
{
    Console.WriteLine($"{ currentCustomer.Id } - { currentCustomer.Name } - { currentCustomer.Email }");
}