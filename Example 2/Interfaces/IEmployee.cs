using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Interface_2
{
    public interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        string Department { get; set; }
        int Salary { get; set; }
        void Show();
    }
}
