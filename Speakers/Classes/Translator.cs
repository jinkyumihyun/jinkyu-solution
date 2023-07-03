using HelperLib;
using Microsoft.VisualBasic.FileIO;
using Speakers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Speakers.Interfaces.ILanguageOption;

namespace Speakers.Classes
{
    public class Translator : AbstractTranslator
    {
        IWordFactory _factory;
        private Translator(string name, LanguageOption option1, LanguageOption option2, IWordFactory factory) 
            : base(name, option1, option2) => _factory = factory;
        public static Translator Create(string name, LanguageOption option1, LanguageOption option2, IWordFactory factory)
       => (Helper.IsNullWhite(name), IsLanguageOption(option1), IsLanguageOption(option2), factory) switch
       {
           (null, _, _, _) => throw new ArgumentException(nameof(name)),
           (_, null, _, _) => throw new ArgumentException(nameof(option1)),
           (_, _, null, _) => throw new ArgumentException(nameof(option2)),
           (_, _, _, null) => throw new ArgumentNullException(nameof(factory)),
           (_, _, _, _) => new Translator(name, option1, option2, factory)
       };
        static LanguageOption? IsLanguageOption(LanguageOption option)
            => Enum.IsDefined(option) ? option : null;

        public static explicit operator Speaker(Translator translator) 
            => Speaker.Create(translator.Name, translator.Languages.Item1, translator._factory);
        public override AbstractWords TranslateAndTell(AbstractWords words)
            => Name == words.Hearer.Name ? Receive(words)
            : (persons.ContainsKey(words.Hearer.Name)) ? SendToSpeaker(words)
            : SendToTranslator(words);
        private AbstractWords Receive(AbstractWords words)
            => _factory.Get($"Ack to  \"{words.Words}\" ", (Speaker)this, words.Speaker, words.Language);
        private AbstractWords SendToSpeaker(AbstractWords words)
        {       
            AbstractWords transWords = persons[words.Hearer.Name].Language == words.Language ? words
                : _factory.Get(words.Words, words.Speaker, words.Hearer, persons[words.Hearer.Name].Language);
           
            Console.WriteLine($"{Name} -> {transWords.Hearer.Name}; {transWords.Language}; {transWords.Speaker.Name} " +
                $"=> {transWords.Hearer.Name}; \"{transWords.Words}\"");

            return persons[transWords.Hearer.Name].Receive(transWords);
        }
        private AbstractWords SendToTranslator(AbstractWords words)
        {
            //routing is lousy, but routing is not the issue here.
            int count = translators.Count;
            Random rand = new Random();
            int idx = rand.Next(0, count);
            var translator = translators.ElementAt(idx).Value;

            AbstractWords transWords = translator.Languages.Contains(words.Language) ? words
                : translator.Languages.Contains(Languages.Item1) ? _factory.Get(words.Words, words.Speaker, words.Hearer, Languages.Item1)
                : translator.Languages.Contains(Languages.Item2) ? _factory.Get(words.Words, words.Speaker, words.Hearer, Languages.Item2)
                : throw new Exception("Translator.SendToTranslator");

            Console.WriteLine($"{Name} -> {translator.Name}; {transWords.Language}; {transWords.Speaker.Name} => {transWords.Hearer.Name}; \"{transWords.Words}\"");
            return translator.TranslateAndTell(transWords);
        }
    }
}