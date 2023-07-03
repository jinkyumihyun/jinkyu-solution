using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone.Classes
{
    public class Person : ICloneable
    {
        public Person(Person person)
        {
            if(person is null) throw new ArgumentNullException(nameof(person));
            Name = person.Name;
            Age = person.Age;
            Address = new Address(person.Address);
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public object Clone()
        {
            var person = (Person)MemberwiseClone();
            person.Address = (Address)Address.Clone();
            return person;
        }
    }

    public class Address : ICloneable
    {
        public Address(Address address)
        {
            if (address is null) throw new ArgumentNullException(nameof(address));
            City = address.City;
            Street = address.Street;
        }
        public string City { get; set; }
        public string Street { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    [Serializable]
    public class Test : ICloneable
    {
        public int i { get; set; }
        public int[] j { get; set; } = { 1, 2, 3, 4 };
        public object Clone()
        {
            var Test = (Test)MemberwiseClone();
            j.CopyTo(Test.j, 0);
            return Test;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var c in j)
            {
                sb.Append(c.ToString() + " ");
            }
            return $"i: {i}    j: {sb.ToString()}";
        }
    }
}

