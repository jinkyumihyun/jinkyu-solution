using Iterator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable.Classes
{
    internal class Factory
    {
        public static Person[] Create()
        {
            return new Person[]
            {
                new Person() {Name = "John", Age = 45},
                new Person() {Name = "Joy", Age = 55},
                new Person() {Name = "Julie", Age = 50},
                new Person() {Name = "Jessi", Age = 46},
                new Person() {Name = "Al", Age = 55},
                new Person() {Name = "Bob", Age = 50},
            };
        }
    }
}
