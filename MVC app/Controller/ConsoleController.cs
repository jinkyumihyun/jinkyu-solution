using MVC_app.Interfaces;
using MVC_app.Model;
using MVC_app.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_app.Controller
{
    internal class ConsoleController
    {
        public void Control() 
        {
            string centinel = "ok";

            while (centinel == "ok")
            {
                Console.Clear();
                Console.WriteLine($"'c' for Creation, 'r' for Read, 'u' for Update, 'd' for destroy, others for Destroy");
                string? request = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(request))
                {
                    request = "not ok";
                }

                IEmployee? employee =
                Char.ToLower(request[0]) switch
                {
                    'c' => new CreateView().ShowView(),

                    'r' => new ReadView().ShowView(),

                    'u' => new UpdateView().ShowView(),

                    'd' => new DestroyView().ShowView(),

                    _ => new NullView().ShowView()
                };  
            }          
        }
    }
}
