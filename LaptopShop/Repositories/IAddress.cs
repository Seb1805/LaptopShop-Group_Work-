using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IAddress
    {
        //Get an address based by address id
        public Address GetAddressByAddressId(int id);
        //Find customers address by their customer id
        public Address GetAddressByCustomerId(int id);

        public IEnumerable<Address> GetAllAdresses();


    }
}
