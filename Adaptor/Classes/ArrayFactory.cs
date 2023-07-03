using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Classes
{
    internal class ArrayFactory
    {
        public static string[,] Create()
        {
            return new string[6, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"One hundred four","Pam","SE","40000"},
                {"105","Sara","SSE","50000"},
                {"106","Sara","SSE","five thousand"}
            };
        }
    }
}
