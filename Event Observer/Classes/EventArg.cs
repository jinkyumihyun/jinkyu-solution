using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Observer.Classes
{
    public class EventArgument
    {
        public EventArgument(string text) => Text = text; 
        public string Text { get; } 
    }
}
