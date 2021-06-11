using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LaptopShop.Model;

namespace LaptopShop.Repositories
{
    class CustomerRepo : ICustomer
    {
        private readonly LaptopContext _laptopContext;


        public Customer GetCustomerById(int id)
        {
            return _laptopContext.customer.First(c => c.CustomerId == id);
        }
        public IEnumerable<Customer> GetCustomerByFullName(string firstname = "", string lastname = "")
        {
            List<Customer> liste = new List<Customer>();
            if (firstname != "") { 
                if (lastname != "") { liste = _laptopContext.customer.Where(c => c.FirstName.Contains(firstname)).Where(c => c.LastName.Contains(lastname)).ToList(); }
                
                liste = _laptopContext.customer.Where(c => c.FirstName.Contains(firstname)).ToList(); }
            else if (lastname != "") { liste = _laptopContext.customer.Where(c => c.LastName.Contains(lastname)).ToList(); }
            return liste;
        }
        public Customer GetCustomerByPhoneNumber(string phoneNumber)
        {
            return _laptopContext.customer.FirstOrDefault(c => c.PhoneNumber == phoneNumber);
        }
        public Customer GetCustomerByEmail(string email)
        {
            return _laptopContext.customer.FirstOrDefault(c => c.Email == email);
        }
    }
}
