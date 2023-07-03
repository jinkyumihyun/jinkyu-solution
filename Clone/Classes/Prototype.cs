using Clone.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone.Classes
{
    public class Person2 : IPrototype<Person2>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address2 Address { get; set; }

        public Person2 CreateDeepCopy()
        {
            var person = (Person2)MemberwiseClone();
            person.Address = Address.CreateDeepCopy();
            return person;
        }
    }

    public class Address2 : IPrototype<Address2>
    {
        public string City { get; set; }
        public string Street { get; set; }

        public Address2 CreateDeepCopy()
        {
            return (Address2)MemberwiseClone();
        }
    }
}
