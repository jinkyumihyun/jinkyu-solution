using Facade.Identification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Identification.Classes
{
    public class Email : IEmail
    {
        public bool SendRegistrationEmail(ICustomer customer)
        {
            Console.WriteLine($"Customer ({customer.Name}) receives a Registration Email through {customer.Email}");
            return true;
        }
    }
}
