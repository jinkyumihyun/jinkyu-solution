using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    internal class GameStartCommand : ICommand
    {
        public VideoGame Game { get; }
        public static GameStartCommand Create(VideoGame game) =>
            game is null ? throw new ArgumentNullException(nameof(game)) : new GameStartCommand(game);
        private GameStartCommand(VideoGame game) => Game = game;   
        public bool Execute() => Game.Start();
        public bool Undo() => Game.End();
        public bool Redo() => Game.Start();
    }
}
