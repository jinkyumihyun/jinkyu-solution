using Prototype.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Interfaces
{
    public interface IEmployee
    {
        string Name { get; set; }

        Address Address { get; set; }
        void ShowDetails();
    }

    public interface IPermanent
    {
        int Salary { get; set; }
        string Department { get; set; }
 
    }
    public interface IPermanentEmployee : IEmployee, IPermanent 
    {
        IPermanentEmployee GetClone();
    }
    public interface ITemporary
    {
        public int FixedAmount { get; set; }

    }

    public interface ITemporaryEmployee : IEmployee, ITemporary {
        ITemporaryEmployee GetClone();
    }

}
