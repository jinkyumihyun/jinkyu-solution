using Facade.Bank.Interfaces;
using Facade.Identification.Classes;
using HelperLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Bank.Classes
{
    public class BankAccounts : IBank
    {
        Dictionary<string, int> _balance = new Dictionary<string, int>();
        public bool Save(string id, int amount)
        => Helper.IsNullWhiteBool(id) ? Helper.Write($"customer id ({id})", false)
            : Helper.IsZeroNegative(amount) is null ? Helper.Write($"amount: {amount} <= 0", false)
            : _balance.ContainsKey(id) ?
              Helper.Do(() => { _balance[id] += amount; Console.WriteLine($"customer ({id}) saves {amount}: balance {_balance[id]}"); })
            : Helper.Do(() => { _balance[id] = amount; Console.WriteLine($"customer ({id}) saves {amount}: balance {_balance[id]}"); });
        public bool Withdraw(string id, int amount)
            =>  ! _balance.ContainsKey(id) ? Helper.Write($"Customer ({id}): no such id", false)
                : amount <= 0 ? Helper.Write($"Customer ({id}): zero or negative amount: {amount} ", false)
                : amount > _balance[id] ? Helper.Write($"Customer ({id}): short of balance : amount: {amount}: balance: {_balance[id]}", false)
                : (_balance[id] -= amount, Helper.Write($"Customer ({id}) withdraws {amount}: balance {_balance[id]}")).Item2;

    }
}
