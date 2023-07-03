using ATM.Interfaces;
using HelperLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ATM.Classes
{
   
    public class Balance : IBalance
    {
        Dictionary<string, int> _balanceSet = new Dictionary<string, int>();
        public Balance(Dictionary<string, int> balanceSet)
            => _balanceSet = balanceSet ?? throw new ArgumentNullException(nameof(balanceSet));
        public bool Withdraw(string user, int amount)
            => (Helper.IsNullWhiteBool(user) || amount <= 0) ? 
                  Helper.Write($"user: null or white spaces ({user}); amount ({amount}) <= 0", false)
                : ! _balanceSet.ContainsKey(user) ? 
                  Helper.Write($"no such user: {user}", false)
                : amount > _balanceSet[user] ? 
                  Helper.Write($"not enough balance: user: {user}; amount: {amount}; balance: {_balanceSet[user]}", false)
                : (_balanceSet[user] -= amount , Helper.Write($"Balance.Withdraw: user: {user}; amount: {amount}; balance: {_balanceSet[user]}")).Item2;
        public bool Save(string user, int amount)
        => (Helper.IsNullWhiteBool(user) || amount <= 0) ? 
              Helper.Write($"user: null or white spaces ({user}); amount ({amount}) <= 0", false)
            : _balanceSet.ContainsKey(user) ? 
              (_balanceSet[user] += amount, Helper.Write($"Balance.Save: user: {user}; amount: {amount}; balance: {_balanceSet[user]}")).Item2
            : Helper.Write($"Balance.Save: user: {user} is not registered", false);
    }
}
