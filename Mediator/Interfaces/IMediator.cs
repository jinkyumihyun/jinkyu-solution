using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Interfaces
{
    public interface IMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
        void Receive(string message, User user);
        ISuperMediator superMediator { get; set; }
    }
}
