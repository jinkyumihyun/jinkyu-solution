using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Interface_2
{
    public interface IIdProducer 
    {
        int Produce();
    };
    public interface INameProducer 
    {
        string Produce();
    };
    public interface ISalaryProducer
    {
        int Produce();
    };
    public interface IDepartmentProducer
    {
        string Produce();
    };

   

}
