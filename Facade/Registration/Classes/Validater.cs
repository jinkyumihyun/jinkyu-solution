using Facade.Identification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Identification.Classes
{
    public class Validator : IValidator
    {
        public bool ValidateCustomer(ICustomer customer)
        {
            //Need to Validate the Customer Object
            //pretend to validate by null or empty checking
            if (customer is null) return false;
            if (string.IsNullOrWhiteSpace(customer.Name)) return false;
            if (string.IsNullOrWhiteSpace(customer.Email)) return false;
            if (string.IsNullOrWhiteSpace(customer.MobileNumber)) return false;
            if (string.IsNullOrWhiteSpace(customer.Address)) return false;
      
            Console.WriteLine($"Customer ({customer.Name}) validated.");
            return true;
        }
    }
}
