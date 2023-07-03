using HelperLib;
using Iterator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Classes
{
    public class Student : IItem
    {
        public int ID { get; }
        public string Name { get; }
        public string SchoolName { get; }
        private Student(string name, int id, string schoolName)
            => (ID, Name, SchoolName) = (id, name, schoolName);
        public override string ToString()
        {
            return $"name: {Name}, id: {ID}, schoolName: {SchoolName}";
        }
        public static IItem Create(string name, int id, string schoolName)
          => (Helper.IsNullWhite(name), Helper.IsZeroNegative(id), Helper.IsNullWhite(schoolName)) switch
          {
              (null, _, _) => throw new ArgumentException(nameof(name)),
              (_, null, _) => throw new ArgumentException(nameof(id)),
              (_, _, null) => throw new ArgumentException(nameof(schoolName)),
              (_, _, _) => new Student(name, id, schoolName)
          };
    }
}
