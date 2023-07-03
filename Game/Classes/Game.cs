using HelperLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Game.Classes
{
    public class VideoGame
    {
        public string Name { get; set; }

        private Random _score = new Random();

        private bool _active = false;
        public VideoGame(string name) => Name = Helper.CheckStr(name, this.GetType().Name);
        public string Status() => _active ? "On" : "Off"; 
        public bool Start() 
            => _active ? Helper.Write($"no-op. The game {Name} is already on.")
            : (_active = true, Helper.Write($"The game {Name} is starting.")).Item2;
        public bool End()
            => _active ? (_active = false,  Helper.Write($"The game {Name} is ending.")).Item2 
            : Helper.Write($"no-op. The game {Name} is already over.");
        public bool DisplayScore()
            => _active ? Helper.Write($"The score of the game {Name} is {_score.Next(100)} : {_score.Next(100)}.")
            : Helper.Write($"no-op. The score is moot. The game {Name} is off.");
    }
}

