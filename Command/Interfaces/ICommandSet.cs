using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Interfaces
{
    public interface ICommandSet
    {
        public ICommand openCommand { get; }
        public ICommand editCommand { get; }
        public ICommand saveCommand { get; }
        public ICommand closeCommand { get; }
    }
}
