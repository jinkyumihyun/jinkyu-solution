using ParamsCommand.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsCommand.Classes
{
    public class MenuOptions
    {
        private ICommand openCommand;
        private ICommand editCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;

        //public MenuOptions(ICommandSet commandSet)
        //{
        //    this.openCommand = commandSet.openCommand;
        //    this.editCommand = commandSet.editCommand;
        //    this.saveCommand = commandSet.saveCommand;
        //    this.closeCommand = commandSet.closeCommand;
        //}
        public MenuOptions(ICommand open, ICommand edit, ICommand save, ICommand close)
        {
            this.openCommand = open;
            this.editCommand = edit;
            this.saveCommand = save;
            this.closeCommand = close;
        }
        //The Invoker cannot handle the Request, so it internally calls the Execute Method
        //of the Command Object. 
        public void ClickOpen(params object[] parameters)
        {
            openCommand.Execute(parameters);
        }
        public void ClickEdit(params object[] parameters)
        {
            editCommand.Execute(parameters);
        }
        //The Invoker cannot handle the Request, so it internally calls the Execute Method
        //of the Command Object. 
        public void ClickSave(params object[] parameters)
        {
            saveCommand.Execute(parameters);
        }
        //The Invoker cannot handle the Request, so it internally calls the Execute Method
        //of the Command Object. 
        public void ClickClose(params object[] parameters)
        {
            closeCommand.Execute(parameters);
        }
    }
}
