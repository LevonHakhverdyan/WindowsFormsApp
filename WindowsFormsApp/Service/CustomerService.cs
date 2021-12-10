using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Persons;

namespace WindowsFormsApp.Service
{
    public class CustomerService
    {
        public static List<Customer> _customers = new List<Customer>();

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }
        public List<Customer> GetAll()
        {
            return _customers;
        }
        public void Update(Customer customer)
        {
            for (int i = 0; i < _customers.Count; i++)
            {
                if (_customers[i].Id == customer.Id)
                {
                    _customers[i] = customer;
                }
            }
        }
        public void Delete(Customer customer)
        {
            _customers.Remove(customer);
        }
        public Customer Get(Guid id)
        {
            for (int i = 0; i < _customers.Count; i++)
            {
                if (_customers[i].Id == id)
                    return _customers[i];
            }
            return default(Customer);
        }
    }
}
