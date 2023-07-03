using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsCommand.Interfaces
{
    abstract class AbstractCommand
    {
		public abstract ICommandSet GetCommandSet(string docName);
	}
}
