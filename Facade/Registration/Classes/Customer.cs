using Facade.Identification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Identification.Classes
{
    public class Customer : ICustomer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}; Email: {Email}; MobileNumber: {MobileNumber}; Address: {Address}  ";
        }
    }
    public sealed class NullCustomer : ICustomer
    {
        private NullCustomer() { }

        private static readonly NullCustomer s_instance = new NullCustomer();
        public static NullCustomer GetInstance() { return s_instance; }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return string.Empty;
        }
    }

}
