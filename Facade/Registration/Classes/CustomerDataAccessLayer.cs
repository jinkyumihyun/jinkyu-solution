using Facade.Identification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Identification.Classes
{
    public class CustomerDataAccessLayer : ICustomerDataAccessLayer
    {
        Dictionary<string, ICustomer> _customers = new Dictionary<string, ICustomer>()
        {
            ["jinkyu"] = new Customer() //sample
            {
                Id = "jinkyu",
                Name = "Jinkyu Kim",
                Email = "jinkyujames@gmail.com",
                MobileNumber = "1234567890",
                Address = "East Orange, N.J., U.S.A."
            }
        };
        public ICustomer GetCustomer(string customerId)
        {
            if (_customers.ContainsKey(customerId))
            {
                return _customers[customerId];
            }
            Console.WriteLine($"Customer ({customerId}): No such customer.");
            return NullCustomer.GetInstance();
        }
        public bool SaveCustomer(ICustomer customer)
        {
            Console.WriteLine($"Customer ({customer.Id}) saved into the Database.");
            _customers[customer.Id] = customer;
            return true;
        }
    }
}
