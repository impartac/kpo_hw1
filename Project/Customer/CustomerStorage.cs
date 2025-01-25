using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccountingInformationSystem;

public class CustomerStorage : ICustomerProvider
{
    List<Customer> customers;

    public List<Customer> GetCustomerList()
    {
        return customers;
    }

    public CustomerStorage()
    {
        customers = new List<Customer>();
    }

    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);
    }
}
