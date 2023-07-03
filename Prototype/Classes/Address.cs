using Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prototype.Classes
{
    public class Address
    {
        public Address(string street, string city, string state)
        {
            Street = street;
            City = city;
            State = state;
        }
    
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Address GetClone()
        {
            return (Address)this.MemberwiseClone();
        }
        public override string ToString()
        {
            return $" {Street} {City}, {State}";
        }
    }
}
