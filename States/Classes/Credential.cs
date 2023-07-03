using ATM.Interfaces;
using HelperLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Classes
{
    public class Credential : ICredential
    {
        Dictionary<string, string> _passwordSet = new Dictionary<string, string>();
        public Credential(Dictionary<string, string> credentialSet)
            => _passwordSet = credentialSet ?? throw new ArgumentNullException(nameof(credentialSet));
        public bool Check(string user, string password)
        => (Helper.IsNullWhiteBool(user) || Helper.IsNullWhiteBool(password)) ?
            Helper.Write("Credentials.Check: user || password: wrong formatted word", false)
            : (_passwordSet.ContainsKey(user) && _passwordSet[user] == password) ?
            Helper.Write($"Credentials.Check: user {user} checked ok.")
            : Helper.Write("Credentials.Check: failed.", false);
        public bool Add(string user, string password)
            => (Helper.IsNullWhiteBool(user) || Helper.IsNullWhiteBool(password)) ? 
            Helper.Write("Credentials.Add: user || password: wrong formatted word", false)
            : (_passwordSet[user] = password, Helper.Write($"Credentials.Add: user: {user}; password: {password}")).Item2;
    }
}
