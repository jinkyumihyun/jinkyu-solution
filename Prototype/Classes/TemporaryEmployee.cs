using Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes
{
    public class TemporaryEmployee : ITemporaryEmployee
    {
        public string Name { get; set; }
        public int FixedAmount { get; set; }
        public Address Address { get; set; }
        public ITemporaryEmployee GetClone()
        {
            ITemporaryEmployee te = (ITemporaryEmployee)this.MemberwiseClone();
            te.Address = Address.GetClone();
            return te;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"TemporaryEmployee: Name: {Name}, FixedAmount: {FixedAmount}; Address: {Address} \n");
        }
    }
}
