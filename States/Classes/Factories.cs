using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Classes
{
    internal class CredentialFactory
    {
        public static Dictionary<string, string> GetCredentials()
            => new Dictionary<string, string>()
            {
                ["john"] = "1234",
                ["jenny"] = "8898",
                ["joy"] = "6363"
            };
    }
    internal class BalaceFactory
    {
        public static Dictionary<string, int> GetBalances()
            => new Dictionary<string, int>()
            {
                ["john"] = 10000,
                ["jenny"] = 20000,
                ["joy"] = 5000
            };
    }
}
