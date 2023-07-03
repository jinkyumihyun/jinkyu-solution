using MVC_app.Interfaces;
using MVC_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_app.Controller
{
    internal class Controller : IController
    {
        IModel model;
        IView view;

        public Controller(IModel model, IView view)
        {
            this.model = model;
            this.view = view;
        }

        public void DisplayEmployees()
        {
            List<Employee> employees = model.GetEmpsFromModel();
            view.ShowEmployees(employees);
        }
        public void AddEmployee(Employee employee)
        {
            model.AddEmpToModel(employee);
        }
        public void RemoveEmployee(string employeeId)
        {
            model.RemoveEmpFromModel(employeeId);
        }
    }
}
