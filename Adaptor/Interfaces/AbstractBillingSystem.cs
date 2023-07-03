using Adaptor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Interfaces
{
    public abstract class AbstractBillingSystem
    {
        public abstract void ProcessSalary(List<IEmployee> listEmployee);
    }
}
