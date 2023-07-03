using Sender.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sender.Classes
{
    public class Factory
    {
        public static AbstractSender GetEmailLong(string message)
        {
            return new Emailsender(new LongMessage(message));
        }
        public static AbstractSender GetSMSLong(string message)
        {
            return new SMSsender(new LongMessage(message)); 
            
        }
        public static AbstractSender GetEmailShort(string message)
        {
            return new Emailsender(new ShortMessage(message)); 
        }
        public static AbstractSender GetSMSShort(string message)
        {
            return new SMSsender(new ShortMessage(message)); 
        }

       

    }
}
