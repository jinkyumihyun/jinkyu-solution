using MVC_app.Interfaces;
using MVC_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_app.View
{
    internal class DestroyView : IView
    {
        public void ShowEmployee(IEmployee employee)
        {
        }
        public IEmployee ShowView()
        {
            return new Employee();
        }
    }
}
