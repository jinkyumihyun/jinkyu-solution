using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Interfaces
{
    public abstract class User
    {
        public string Name { get; }

        private IMediator _mediator;
        public IMediator Mediator 
        { 
            get { return _mediator; }
            set { _mediator = value ?? throw new Exception(nameof(Mediator)); } 
        }
        public User(string name) => this.Name = name;
        public abstract void Send(string message);
        public abstract void Receive(string message, User user);
    }
}
