using Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Classes2
{
    public class Expression : IExpression
    {
        public Expression(string replacee, string replacer)
            => (_replacee, _replacer) = (replacee, replacer);

        string _replacee;         
        string _replacer;
        public void Evaluate(Context context)
            => context.Expression = context.Expression.Replace(_replacee, _replacer);
    }
}
