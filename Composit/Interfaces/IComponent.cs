using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit.Interfaces
{  
    public interface IComp
    {
        int GetSalary();
    }

    public interface ILeaf : IComp
    {
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public interface IComposite : IComp
    {
        public void AddComponent(IComp NewComponent);
        public void RemoveComponent(IComp RemoveComponent);
    }      
}
