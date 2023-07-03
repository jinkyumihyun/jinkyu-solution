using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Identification.Interfaces
{
    public interface ICustomerDataAccessLayer
    {
        public ICustomer? GetCustomer(string customerId);
        public bool SaveCustomer(ICustomer customer);

    }
}
