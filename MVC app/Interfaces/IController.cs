using MVC_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_app.Interfaces
{
    internal interface IController
    {
        void DisplayEmployees();
        void AddEmployee(Employee employee);
        void RemoveEmployee(string employeeId);
    }
}
