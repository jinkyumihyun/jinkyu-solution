using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Classes
{
    public class OpenCommand : ICommand
    {
        private Document document;
        public OpenCommand(Document doc) 
            => document = doc ?? throw new ArgumentNullException(nameof(doc));
        public void Execute() => document.Open();
    }

    public class EditCommand : ICommand
    {
        private Document document;
        public EditCommand(Document doc) 
            => document = doc ?? throw new ArgumentNullException(nameof(doc));
        public void Execute() => document.Edit();
    }

    class SaveCommand : ICommand
    {
        private Document document;
        public SaveCommand(Document doc) 
            => document = doc ?? throw new ArgumentNullException(nameof(doc));
        public void Execute() => document.Save();
    }

    class CloseCommand : ICommand
    {
        private Document document;
        public CloseCommand(Document doc) 
            => document = doc ?? throw new ArgumentNullException(nameof(doc));
        public void Execute() => document.Close();
    }
}
