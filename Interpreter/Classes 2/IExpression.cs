using Interpreter.Classes2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Classes2
{
    public interface IExpression
    {
        void Evaluate(Context context);
    }
}
