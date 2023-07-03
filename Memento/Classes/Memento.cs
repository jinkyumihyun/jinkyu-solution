using Memento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Classes
{
    public class Memento
    {
        public DateTime Time { get;  }
        public ITV TV { get; set; }
        private Memento(ITV TV) => (this.TV, Time) = (TV.Clone(), DateTime.Now);
        public static Memento Create(ITV TV)
       => TV switch
       {
           null => throw new ArgumentNullException(nameof(TV)),
           _ => new Memento(TV)
       };
        public string GetDetails() => $"Memento [Time = {Time}; TV = {TV.GetDetails()}]";
    }
}
