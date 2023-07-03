using Command.Classes;
using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Interfaces
{
    public abstract class AbstractFactory
    {
        public abstract ICommandSet GetCommandSet(string docName);
        public abstract ICommandSet GetCommandSet(Document doc);
    }
}
