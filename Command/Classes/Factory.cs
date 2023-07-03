using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Command.Classes
{
    public class Factory : AbstractFactory
    {
        public override ICommandSet GetCommandSet(Document doc) => CommandSet.Create(doc);        
        public override ICommandSet GetCommandSet(string docName) => CommandSet.Create(docName);
    }
}
