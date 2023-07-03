using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observers.Interfaces
{
    public interface IObserver
    {
        // Receive Notification from Subject
        void Update(INotice notice);

    }
}
