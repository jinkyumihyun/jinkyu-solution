using Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Classes
{
    public class ConcreteUser : User
    {
        public ConcreteUser(string Name) : base(Name) { }
        public override void Receive(string message, User sender) 
            => Console.WriteLine(this.Name + $": from {sender.Name}: \"" + message + "\"");

        public override void Send(string message)
        {
            Console.WriteLine(this.Name + ": Sending Message: \"" + message + "\"");
            Mediator.SendMessage(message, this);
        }
    }
}
