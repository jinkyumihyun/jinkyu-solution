using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Classes;
using Visitor.Interfaces;

namespace Visitor.Factories
{
    public class ElemFactory
    {
        public static List<IElement> Get()
        {
            return new List<IElement>
            {
                new Kid("Bob"),
                new Kid("Sarah"),
                new Kid("Pamela"),
                new Parent("John"),
                new Parent("Mary"),
                new Teacher("Kaitlin"),
                new Teacher("Robert"),
                new Assistant("Kay")
            };
        }
    }
}
