using MVC_app.Interfaces;
using MVC_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_app.View
{
    internal class ConsoleView : IView
    {
        public void ShowEmployee(Employee employee)
        {
            Console.Clear();
                Console.WriteLine(employee);
        }
        public IEmployee ShowView()
        {
            Console.Clear();

            while (true)
            {
                Console.Write("0 to create; 1 to read, 2 to update, 3 to destroy:");
                string? option = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(option) || ! Int32.TryParse(option, out int opt))
                {
                    Console.Write($"wrong option string: {option}");
                    continue;
                }
                switch(opt)
                {
                    case 0:
                        return new CreateView().ShowView();
                    case 1:
                        return new ReadView().ShowView();
                    case 2:
                        return new UpdateView().ShowView();
                    case 3:
                        return new DestroyView().ShowView();
                    default:
                        Console.Write($"wrong option value: {opt}");
                        continue;
                }
            }         
        }
    }
}
