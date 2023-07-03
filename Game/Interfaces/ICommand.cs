using Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interfaces
{
    internal interface ICommand
    {
        VideoGame Game
        {
            get;
        }
        bool Execute();
        bool Undo();
        bool Redo();
    }
}
