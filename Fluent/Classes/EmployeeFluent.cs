using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Classes
{
    public class FluentEmployee
    {
        private Employee _employee;

        public FluentEmployee(Employee employee)
        {
            this._employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }
        public FluentEmployee NameOfTheEmployee(string FullName)
        {
            _employee.FullName = FullName;
            return this;
        }
        public FluentEmployee Born(string DateOfBirth)
        {
            _employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return this;
        }
        public FluentEmployee WorkingOn(string Department)
        {
            _employee.Department = Department;
            return this;
        }
        public FluentEmployee StaysAt(string Address)
        {
            _employee.Address = Address;
            return this;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Name: {_employee.FullName}, \nDateOfBirth: {_employee.DateOfBirth}, \nDepartment: {_employee.Department}, \nAddress: {_employee.Address}");
        }
    }
}
