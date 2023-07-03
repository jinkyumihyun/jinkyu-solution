using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Classes
{
    public class CommandSet : ICommandSet
    {
        public ICommand openCommand { get; }
        public ICommand editCommand { get;  }
        public ICommand saveCommand { get;  }
        public ICommand closeCommand { get; }
        private CommandSet(Document doc) =>
            (openCommand, editCommand, saveCommand, closeCommand) 
            = (new OpenCommand(doc), new EditCommand(doc), new SaveCommand(doc), new CloseCommand(doc));
        public static CommandSet Create(Document doc) =>
            doc is null ? throw new ArgumentNullException(nameof(doc)) : new CommandSet(doc);
        public static CommandSet Create(string docName) =>
            string.IsNullOrWhiteSpace(docName) ? throw new ArgumentException(nameof(docName))
            : new CommandSet(new Document(docName));
    }
}
