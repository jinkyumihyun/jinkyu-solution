using Sender.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender.Classes
{
    public class Emailsender : AbstractSender
    {
        public Emailsender(AbstractMessage message) 
        {
            this.message = message;
        }
        public Emailsender() { }

        private string TmpMessage;
        public override void SendMessage()
        {
            this.TmpMessage = this.message.ProcessMessage();
            Send();
        }

        public override void SendMessage(AbstractMessage message)
        {
            this.TmpMessage = message.ProcessMessage();
            Send();
        }
        private void Send()
        {
            if (TmpMessage != string.Empty)
            {
                Console.WriteLine(TmpMessage);
                Console.WriteLine("This Message has been sent using Emailsender");
            }
            else
            {
                Console.WriteLine("The message is not sent. Emailsender");
            }
        }

    }
}
