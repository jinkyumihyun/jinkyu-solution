using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Bank.Interfaces
{
    internal interface IBank
    {
        bool Save(string id, int amount);
        bool Withdraw(string id, int amount);
    }
}
