using MVC_app.Interfaces;
using MVC_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_app.View
{
    internal class CreateView : IView
    {
        public IEmployee? ShowView()
        {
            Console.Clear();
            Console.Write("Name: ");
            string name = Console.ReadLine() ?? string.Empty;
            Console.Write("Address: ");
            string address = Console.ReadLine() ?? string.Empty;
            Console.Write("0 to create; 1 to cancel: ");
            string? option = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(option))
            {
                option = "1";
            }
            
            return option[0] == '0' ? new Employee(name, address) : null;
        }
    }
}