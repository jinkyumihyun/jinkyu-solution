using Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Classes
{
    public class SuperMediator : ISuperMediator
    {
        private List<IMediator> MediatorList = new List<IMediator>();
        public void RegisterMediator(IMediator mediator)
        {
            if (mediator is null) throw new ArgumentNullException(nameof(mediator));

            MediatorList.Add(mediator);
            mediator.superMediator = this;                    
        }
        public void SendMessage(string msg, IMediator sendingMediator, User sender)
        {
            if (sendingMediator is null || sender is null) throw new ArgumentNullException(nameof(sendingMediator));

            MediatorList.ForEach(m => { if (! object.ReferenceEquals(m, sendingMediator)) m.Receive(msg, sender); });
        }                    
    }
}
