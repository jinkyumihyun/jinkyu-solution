using MVC_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_app.Model
{
    internal class EmployeeModel : IModel
    {
        const int NumEmps = 5;

        Employee[] _employees = new Employee[NumEmps];
        public EmployeeModel(Employee[] employees)
        {
            _employees = employees;
        }
        public Employee[] GetEmpsFromModel()
        {
            return _employees;
        }
        public void AddEmpToModel(Employee employee)
        {
            if (! _employees.Contains(employee))
            {
                _employees.Add(employee);
            }
        }
        public void RemoveEmpFromModel(string empId)
        {
            Employee ToBeRemoved = FindEmpWithID(empId);
            if (ToBeRemoved != null)
            {
                _employees.Remove(ToBeRemoved);
            }
        }
        private Employee FindEmpWithID(string empId)
        {
            return null;
        }
    }
}
