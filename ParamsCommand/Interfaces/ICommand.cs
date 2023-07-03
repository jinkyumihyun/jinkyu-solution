using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsCommand.Interfaces
{
    public interface ICommand
    {
        void Execute(params object[] parameters);
    }
}
