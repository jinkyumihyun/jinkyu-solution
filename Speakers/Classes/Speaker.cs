using HelperLib;
using Speakers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Speakers.Interfaces.ILanguageOption;

namespace Speakers.Classes
{
    public class Speaker : AbstractSpeaker
    {
        IWordFactory _factory;
        private Speaker(string name, LanguageOption option, IWordFactory factory) : base(name, option)
            => _factory = factory;
        public static Speaker Create(string name, LanguageOption option, IWordFactory factory)
        => (Helper.IsNullWhite(name), IsLanguageOption(option), factory) switch
        {
           (null, _, _) => throw new ArgumentException(nameof(name)),
           (_, null, _) => throw new ArgumentException(nameof(option)),
           (_, _, null) => throw new ArgumentNullException(nameof(factory)),
           (_, _, _) => new Speaker(name, option, factory)
        };
        static LanguageOption? IsLanguageOption(LanguageOption option) => Enum.IsDefined<LanguageOption>(option) ? option : null;
        public override string Speak(string words, AbstractSpeaker receiver)
        {
            Console.WriteLine($"{Name} -> {Translator.Name}; {Language}; {Name} => {receiver.Name}; \"{words}\"");
            var languageWords = _factory.Get(words, this, receiver, Language);
            var response = Translator.TranslateAndTell(languageWords);
            return response.Words;
        }
        public override AbstractWords Receive(AbstractWords words)
        => _factory.Get($"Ack to \"{words.Words}\" ", this, words.Speaker, Language);
    }
}
