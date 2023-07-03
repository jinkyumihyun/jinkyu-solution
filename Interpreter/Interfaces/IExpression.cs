using Interpreter.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Interfaces
{
    public interface IExpression
    {
        void Evaluate(Context context);
    }
}
