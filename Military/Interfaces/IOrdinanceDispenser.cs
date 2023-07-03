using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military.Interfaces
{
    public interface IOrdinanceDispenser
    {
        bool DispenseOrdinance(ref int numberBullets, ref int numberShells);
       
    }
}
