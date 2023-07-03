using Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Classes
{
    public class ConcreteFacebookGroupMediator : IMediator
    {
        private List<User> UsersList = new List<User>();

        private ISuperMediator _superMediator;
        public ISuperMediator superMediator 
        {
            get { return _superMediator; }
            set { _superMediator = value ?? throw new ArgumentNullException(nameof(value)); } 
        }
        public void RegisterUser(User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));

            UsersList.Add(user);
            user.Mediator = this;      
        }
        public void Receive(string message, User sender)
        {
            if (sender is null) throw new ArgumentNullException(nameof(sender));

            UsersList.ForEach(u => { if (! object.ReferenceEquals(u, sender)) u.Receive(message, sender); });
        }
        public void SendMessage(string message, User sender)
        {
            if (sender is null) throw new ArgumentNullException(nameof(sender));

            superMediator.SendMessage(message, this, sender);
            UsersList.ForEach(u => { if (!object.ReferenceEquals(u, sender)) u.Receive(message, sender); });
        }
    }
}
