using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Interfaces
{
    public interface ISuperMediator
    {
        void SendMessage(string msg, IMediator mediator, User u);
        void RegisterMediator(IMediator mediator);
    }
}
