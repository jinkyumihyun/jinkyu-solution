using MVC_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_app.Model
{
    internal class Employee : IEmployee, IEquatable<Employee>
    {
        public Employee(string empName,  string address)
        {
            Name = empName;
            Id = ++s_idSeed;
            Address = address;
        }
        public Employee() { Id = ++s_idSeed; }
        public string Name { get; set; }

        private static int s_idSeed = 0;
        public int Id { get;}
        public string Address { get; set; }
        public override string ToString() 
        {
            return $"{Name} is registered with {Id} and {Address}.";
        }
        public override bool Equals(object? obj) //overriding
        {
            if (object.ReferenceEquals(obj, null))
                return false;
            Employee? objAsPart = obj as Employee;
            if (object.ReferenceEquals(objAsPart, null))
                return false;
            return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return Id;
        }
        public bool Equals(Employee? other) //implementing
        {
            if (object.ReferenceEquals(other, null)) 
                return false;
            return Id.Equals(other.Id);
        }
        public static bool operator ==(Employee emp1, Employee emp2) //overloading
        {
            if (object.ReferenceEquals(emp1, emp2)) return true;
            if (object.ReferenceEquals(emp1, null)) return false;
            if (object.ReferenceEquals(emp2, null)) return false;

            return emp1.Equals(emp2);
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
    }
}
