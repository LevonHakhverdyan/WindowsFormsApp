using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Persons
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }
        public Customer(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
