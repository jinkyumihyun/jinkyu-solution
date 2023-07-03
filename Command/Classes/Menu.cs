using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Classes
{
    public class MenuOptions
    {
        private ICommand openCommand;
        private ICommand editCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;
        private MenuOptions(ICommandSet commandSet) =>
            (this.openCommand, this.editCommand, this.saveCommand, this.closeCommand)
            = (commandSet.openCommand, commandSet.editCommand, commandSet.saveCommand, commandSet.closeCommand);
        public static MenuOptions Create(ICommandSet commandSet) =>
           commandSet is null ? throw new ArgumentNullException(nameof(commandSet)) : new MenuOptions(commandSet);
        private MenuOptions(ICommand open, ICommand edit, ICommand save, ICommand close) =>
             (this.openCommand, this.editCommand, this.saveCommand, this.closeCommand)
            = (open, edit, save, close);
        public static MenuOptions Create(ICommand open, ICommand edit, ICommand save, ICommand close)
        => (open, edit, save, close) switch
       {
           (null, _, _, _) => throw new ArgumentNullException(nameof(open)),
           (_, null, _, _) => throw new ArgumentNullException(nameof(edit)),
           (_, _, null, _) => throw new ArgumentNullException(nameof(save)),
           (_, _, _, null) => throw new ArgumentNullException(nameof(close)),
           (_, _, _, _) => new MenuOptions(open, edit, save, close)
       };
        public void ClickOpen() => openCommand.Execute();
        public void ClickEdit() => editCommand.Execute();  
        public void ClickSave() => saveCommand.Execute();
        public void ClickClose() => closeCommand.Execute();
        public void ClickAll()
        {
            ClickOpen();
            ClickEdit();
            ClickSave();
            ClickClose();
        }
    }
}
