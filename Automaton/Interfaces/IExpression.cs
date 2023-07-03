using Automaton.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaton.Interfaces
{
    public interface IExpression
    {
        string Evaluate(string context);
    }
}
