using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LaptopShop.Model;
using LaptopShop.Data;

namespace LaptopShop.Repositories
{
    class CustomerRepo : ICustomer
    {
        private readonly LaptopContext _context;


        public CustomerRepo(LaptopContext context)
        {
            _context = context;
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.First(c => c.CustomerId == id);
        }
        public IEnumerable<Customer> GetCustomerByFullName(string firstname = "", string lastname = "")
        {
            List<Customer> liste = new List<Customer>();
            if (firstname != "") { 
                if (lastname != "") { liste = _context.Customers.Where(c => c.FirstName.Contains(firstname)).Where(c => c.LastName.Contains(lastname)).ToList(); }
                
                liste = _context.Customers.Where(c => c.FirstName.Contains(firstname)).ToList(); }
            else if (lastname != "") { liste = _context.Customers.Where(c => c.LastName.Contains(lastname)).ToList(); }
            return liste;
        }
        public Customer GetCustomerByPhoneNumber(string phoneNumber)
        {
            return _context.Customers.FirstOrDefault(c => c.PhoneNumber == phoneNumber);
        }
        public Customer GetCustomerByEmail(string email)
        {
            return _context.Customer.FirstOrDefault(c => c.EmailAddress == email);
        }
    }
}
