using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observers.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void SetPrice(string product, int price);
        void RegisterSubject(ISubject subject);
        void RemoveSubject(ISubject subject); 
        void Update(INotice notice);

    }
}
