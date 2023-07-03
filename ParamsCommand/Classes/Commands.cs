using ParamsCommand.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsCommand.Classes
{
    public class OpenCommand : ICommand
    {
        private Document document;
        public OpenCommand(Document doc)
        {
            document = doc;
        }
        //Execute Method will internally call the Receiver Object Open Method
        public void Execute(params object[] parameters)
        {
            document.Open((int)parameters[0]);
        }
    }

    public class EditCommand : ICommand
    {
        private Document document;
        public EditCommand(Document doc)
        {
            document = doc;
        }
        public void Execute(params object[] parameters)
        {
            document.Edit((string)parameters[0]);
        }
    }

    class SaveCommand : ICommand
    {
        private Document document;
        public SaveCommand(Document doc)
        {
            document = doc;
        }
        //Execute Method will internally call the Receiver Object Save Method
        public void Execute(params object[] parameters)
        {
            document.Save((bool)parameters[0]);
        }
    }

    class CloseCommand : ICommand
    {
        private Document document;
        public CloseCommand(Document doc)
        {
            document = doc;
        }
        //Execute Method will internally call the Receiver Object Close Method
        public void Execute(params object[] parameters)
        {
            document.Close();
        }
    }
}
