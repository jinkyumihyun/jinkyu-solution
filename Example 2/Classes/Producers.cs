using DependencyInversion.Interface_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DependencyInversion.Classes_2
{
    //Mock id, name, salary, department generators
    public class IdProducer : IIdProducer
    {
        private int _id = 0;
        public int Produce() => ++_id;
    };
    public class NameProducer : INameProducer
    {
        private string[] _names  = { "John", "Mary", "Joseph", "Joy", "Larry"};
        private int _idx = 0;
        public string Produce() => _names[++_idx % _names.Length] ;
    };
    public class SalaryProducer : ISalaryProducer
    {
        private int[] _salaries = { 60000, 70000, 80000, 75000, 65000, 90000, 95000, 77000, 99000  };
        private int _idx = 0;
        public int Produce() => _salaries[++_idx % _salaries.Length];
    };
    public class DepartmentProducer : IDepartmentProducer
    {
        private string[] _departments = { "Software", "Sales", "HR", "Operations" };
        private int _idx = 0;
        public string Produce() => _departments[++_idx % _departments.Length];
    };
}
