using Adaptor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adaptor.Classes
{
    public class Employee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
        private Employee(string id, string name, string designation, string salary)
        {
            try
            {
                ID = Convert.ToInt32(id);
                Name = name;
                Designation = designation;
                Salary = Convert.ToDecimal(salary);
            }
            catch 
            {
                ID = default; //tag for not being userble
            }
        }
        public static IEmployee? Create(string[] employee)
            => employee is null ? null : new Employee(employee[0], employee[1], employee[2], employee[3]);
    }
}
