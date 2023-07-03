using Iterator.Classes;
using Iterator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Classes
{
    internal class Factory
    {
        public static IItem[] Create()
        {
            return new IItem[] 
            {
                new Elempoyee("Anurag", 100),
                Student.Create("AnuragA", 100, "A"),
                Student.Create("AnuragB", 101, "B"),
                Student.Create("AnuragC", 102, "C"),
                NullItem.GetInstance(),
                new Elempoyee("Pranaya", 101),
                new Elempoyee("Santosh", 102),
                new Elempoyee("Priyanka", 103),
                new Elempoyee("Abinash", 104),
                new Elempoyee("Preety", 105)
            };
        }
    }
}
