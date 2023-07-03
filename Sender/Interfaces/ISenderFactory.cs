using Sender.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender.Interfaces
{
    public interface ISenderFactory
    {
        AbstractSender GetLongMessage(string message);
        AbstractSender GetShortMessage(string message);
        AbstractSender GetSender();
    }
}
