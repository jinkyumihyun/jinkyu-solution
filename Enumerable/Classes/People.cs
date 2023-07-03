using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Classes
{
    public class People : IEnumerable
    {
        private Person[] _people;
        public People(Person[] people) => _people = people ?? throw new ArgumentNullException(nameof(people));
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public PeopleEnum GetEnumerator() => new PeopleEnum(_people);
    }
}
