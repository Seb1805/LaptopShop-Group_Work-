using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Model;

namespace LaptopShop.Repositories
{
    interface ICustomer
    {
        public Customer GetCustomerById(int id);
        public IEnumerable<Customer> GetCustomerByFullName(string firstname, string lastname);
        public Customer GetCustomerByPhoneNumber(string phoneNumber);
        public Customer GetCustomerByEmail(string email);
    }
}
