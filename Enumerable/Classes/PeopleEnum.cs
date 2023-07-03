using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Classes
{
    public class PeopleEnum : IEnumerator
    { 
        public Person[] _people;

        int position = -1;
        public PeopleEnum(Person[] list) 
            => _people = list ?? throw new ArgumentNullException(nameof(list));
        public bool MoveNext() => ++position < _people.Length;
        public void Reset() => position = -1;
        object IEnumerator.Current => this.Current;
        public Person Current =>
            position < _people.Length ? _people[position]
            : throw new InvalidOperationException();
    }
}
