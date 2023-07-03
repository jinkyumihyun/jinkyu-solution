using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    internal class GameScoreCommand : ICommand
    {
        public VideoGame Game { get; }
        public static GameScoreCommand Create(VideoGame game) =>
            game is null ? throw new ArgumentNullException(nameof(game)) : new GameScoreCommand(game);
        public GameScoreCommand(VideoGame game) => Game = game;
        public bool Execute() => Game.DisplayScore();
        public bool Undo() => Wrt("no-op. nothing to undo");
        public bool Redo() => Game.DisplayScore();

        private bool Wrt(string msg)
        {
            Console.WriteLine(msg);
            return true;
        }
    }
}
