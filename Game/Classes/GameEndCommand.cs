using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    internal class GameEndCommand : ICommand    
    {
        public VideoGame Game { get; }
        public static GameEndCommand Create(VideoGame game) =>
            game is null ?  throw new ArgumentNullException(nameof(game)) : new GameEndCommand(game);
        private GameEndCommand(VideoGame game) => Game = game;
        public bool Execute() => Game.End();
        public bool Undo() => Game.Start();
        public bool Redo() => Game.End();
    }
}
