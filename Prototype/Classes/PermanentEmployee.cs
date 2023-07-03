using Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes
{
    public class PermanentEmployee : IPermanentEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public Address Address { get; set; }
        public IPermanentEmployee GetClone()
        {
            IPermanentEmployee pe = (IPermanentEmployee)this.MemberwiseClone();
            pe.Address = Address.GetClone();
            return pe;
        }
        public void ShowDetails()
            => Console.WriteLine($"Permanent: Name: {Name}; Department: {Department}; Salary: {Salary}; Address:{Address}\n");
    }
}
