using MVC_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_app.Model
{
    internal class EmployeeDB : IModel
    {
        List<Employee> _employees;
        //public EmployeeDB(List<Employee> employees)
        //{
        //    _employees = employees;
        //}
        public List<Employee> GetEmpsFromModel()
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
//save into file using JSON format
