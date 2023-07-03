using DependencyInversion.Interface_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Classes_2
{
    public class Employee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public override string ToString()
        {
            return $"{ID}: {Name}: {Department}: {Salary}";
        }
        public void Show()
        {
            Console.WriteLine(ToString());
        }
    }
}
