using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Classes
{
    public class FluentPerson
    {
        private Person person = new Person();
        public FluentPerson FName(string Name)
        {
            person.FullName = Name;
            return this;
        }
        public FluentPerson DOB(DateTime date)
        {
            person.DateOfBirth = date;
            return this;
        }
        public FluentPerson ADR(string address)
        {
            person.Address = address;
            return this;
        }
        public string GetName()
        {
            return person.FullName;
        }
    }
}
