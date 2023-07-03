using Game.Interfaces;
using HelperLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    internal class RemoteControl
    {
        private RemoteControl(VideoGame game) => SetCommandGame(game);
        public static RemoteControl Create(VideoGame game) 
            => game is null ? throw new ArgumentNullException(nameof(game)) : new RemoteControl(game);
        public bool SetGame(VideoGame game) 
            => game is null ? throw new ArgumentNullException(nameof(game)) : SetCommandGame(game);      
        private bool SetCommandGame(VideoGame game)
        {
            _game = game;
            _commands["Start"] = GameStartCommand.Create(game);
            _commands["End"] = GameEndCommand.Create(game);
            _commands["Score"] = GameScoreCommand.Create(game);
            _commandStack.Clear();
            return true;
        }

        private readonly Dictionary<string, ICommand> _commands = new Dictionary<string, ICommand>();

        private readonly Stack<ICommand> _commandStack = new Stack<ICommand>();

        private VideoGame _game;
        public string Status() => _game.Status();
        public void Start()
            => Helper.Do(() => {_commandStack.Push(_commands["Start"]); _commands["Start"].Execute();});
        public void ShowScore()
             => Helper.Do(() => { _commandStack.Push(_commands["Score"]); _commands["Score"].Execute(); });
        public void End()
             => Helper.Do(() => { _commandStack.Push(_commands["End"]); _commands["End"].Execute(); });
        public void Undo()
        {
            if (_commandStack.Count > 0)
            {
                var command = _commandStack.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine("no command to undo");
            }
        }
        public void Redo()
        { 
            if (_commandStack.Count > 0)
            {
                var command = _commandStack.Peek();
                _commandStack.Push(command);
                command.Redo();
            }
            else
            {
                Console.WriteLine("no command to redo");
            }                
        }
    }
}
