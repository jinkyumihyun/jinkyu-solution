using Observers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observers.Classes
{
    public class Shopper : IObserver
    {
        public string UserName { get; set; }
        public Shopper(string userName) => UserName = userName;
        public void Update(INotice notice)
            => Console.WriteLine($"Hello {UserName}, Product ({notice.Item}) is now ${notice.Price} at the \"{notice.Store}\" store.");
    }
}
