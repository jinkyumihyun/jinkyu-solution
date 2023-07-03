using Adaptor.Interfaces;
using Adaptor.Ref_code;
using Employees.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor.Classes
{
    public class EmployeeAdapter : ITarget
    {
        public EmployeeAdapter(AbstractBillingSystem thirdPartyBillingSystem)
            => _thirdPartyBillingSystem = thirdPartyBillingSystem 
                ?? throw new ArgumentNullException(nameof(thirdPartyBillingSystem));

        AbstractBillingSystem _thirdPartyBillingSystem;     
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<IEmployee> listEmployee = new List<IEmployee>();

            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                var e = Employee.Create(employeesArray.GetRowVector(i));
                if (e is not null)
                {
                    listEmployee.Add(e);
                }              
            }
           
            _thirdPartyBillingSystem.ProcessSalary(listEmployee);
        }
    }
    

}
