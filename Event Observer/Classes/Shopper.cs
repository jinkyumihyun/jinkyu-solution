using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Observer.Classes
{
    public class Shopper
    {
        public Shopper(string userName) => _userName = userName;

        private string _userName;
        public Publisher? Publisher { get;  set; }      
        public void ShowEvent(object sender, EventArgument e)
            => Console.WriteLine($"UserName: {_userName}: {e.Text}");
        public void Ask(string product) => Publisher?.AskPrice(product);
    }
}
