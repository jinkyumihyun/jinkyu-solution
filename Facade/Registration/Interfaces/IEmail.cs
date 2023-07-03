using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Identification.Interfaces
{
    public interface IEmail
    {
        public bool SendRegistrationEmail(ICustomer customer);
    }
}
