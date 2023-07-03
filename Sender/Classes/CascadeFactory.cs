using Sender.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender.Classes
{
    class CascadeFactory
    {
        public static ISenderFactory GetSMSsender()
        {
            return new SMSsenderFactory();
        }
        public static ISenderFactory GetEmailSender()
        {
            return new EmailSenderFactory();
        }
        class SMSsenderFactory : ISenderFactory
        {
            public AbstractSender GetLongMessage(string message)
            {
                return new SMSsender(new LongMessage(message));
            }
            public AbstractSender GetShortMessage(string message)
            {
                return new SMSsender(new ShortMessage(message));
            }
            public AbstractSender GetSender()
            {
                return new SMSsender();
            }
        }
        class EmailSenderFactory : ISenderFactory
        {
            public AbstractSender GetLongMessage(string message)
            {
                return new Emailsender(new LongMessage(message));
            }
            public AbstractSender GetShortMessage(string message)
            {
                return new Emailsender(new ShortMessage(message));
            }
            public AbstractSender GetSender()
            {
                return new Emailsender();
            }
        }

    }
}
