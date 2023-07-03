using Adaptor.Interfaces;
using Employees.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor.Classes
{
    public class ThirdPartyBillingSystem : AbstractBillingSystem
    {
        public override void ProcessSalary(List<IEmployee> listEmployee)
        {
            listEmployee.ForEach(employee => 
            {
                if (employee.ID == default) return;
                Console.WriteLine($"ID: {employee.ID}; Name: {employee.Name}; Designation: {employee.Designation}; Salary: {employee.Salary}");
                Console.WriteLine($"Salary: ${employee.Salary} Credited to the \"{employee.Name}\"'s Account.\n");
            });
        }
    }
}
