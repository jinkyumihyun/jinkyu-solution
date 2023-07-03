using Message.Classes;
using Message.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message.Factories
{
    public class ExtendedAbstractFactory : AbstractFactory
    {
        public static AbstractMessage GetFacsimileLongA(string message)
        {
            return LongMessage.Create(new FacsimileSender(), new MessageProcessorA(), message);
        }
        public static AbstractMessage GetFacsimileShortA(string message)
        {
            return ShortMessage.Create(new FacsimileSender(), new MessageProcessorA(), message);
        }
        public static AbstractMessage GetFacsimileLongB(string message)
        {
            return LongMessage.Create(new FacsimileSender(), new MessageProcessorB(), message);
        }
        public static AbstractMessage GetFacsimileShortB(string message)
        {
            return ShortMessage.Create(new FacsimileSender(), new MessageProcessorB(), message);
        }
    }
}
