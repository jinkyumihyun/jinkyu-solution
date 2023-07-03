using Sender.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender.Classes
{
    public class SMSsender : AbstractSender
    {
        public SMSsender(AbstractMessage message)
        {
            this.message = message;
        }
        public SMSsender() {}

        private string TmpMessage;
        public override void SendMessage()
        {
            TmpMessage = this.message.ProcessMessage();
            Send();
        }
        public override void SendMessage(AbstractMessage message)
        {
            TmpMessage = message.ProcessMessage();
            Send();
        }
        private void Send()
        {
            if (TmpMessage != string.Empty)
            {
                Console.WriteLine(TmpMessage);
                Console.WriteLine("This Message has been sent using SMSsender");
            }
            else
            {
                Console.WriteLine("The message is not sent. SMSsender");
            }
        }
    }
}
