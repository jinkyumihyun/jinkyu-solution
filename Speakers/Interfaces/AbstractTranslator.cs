using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Speakers.Interfaces.ILanguageOption;

namespace Speakers.Interfaces
{
    public abstract class AbstractTranslator
    {
        protected AbstractTranslator(string name, LanguageOption option1, LanguageOption option2)
        => (Name, Languages) = (name, new (option1, option2));
        public Tuple<LanguageOption, LanguageOption> Languages { get; }
        public string Name { get; }

        protected Dictionary<string, AbstractSpeaker> persons = new Dictionary<string, AbstractSpeaker>();
        public bool Register(AbstractSpeaker speaker)
        {
            if (! Languages.Contains(speaker.Language))
            {
                throw new Exception("AbstractTranslator.Register speaker");
            }
            if (!persons.ContainsKey(speaker.Name))
            {
                persons[speaker.Name] = speaker;
                return speaker.Register(this);
            }
            return true;
        }

        protected Dictionary<string, AbstractTranslator> translators = new Dictionary<string, AbstractTranslator>();
        public bool Register(AbstractTranslator translator)
        {
            if (! Languages.Overlaps(translator.Languages))
            {
                throw new Exception("AbstractTranslator.Register translator");
            }
            if (!this.translators.ContainsKey(translator.Name))
            {
                this.translators[translator.Name] = translator;
                return translator.Register(this);
            }
            return true;
        }
        public abstract AbstractWords TranslateAndTell(AbstractWords words);
    }

    public static class TupleUtility {
        public static bool Contains(this Tuple<LanguageOption, LanguageOption> T, LanguageOption option)
        {
            return T.Item1 == option || T.Item2 == option;
        }
        public static bool Overlaps(this Tuple<LanguageOption, LanguageOption> T1, Tuple<LanguageOption, LanguageOption> T2)
        {         
            return T1.Item1 == T2.Item1 || T1.Item1 == T2.Item2
                   || T1.Item2 == T2.Item1 || T1.Item2 == T2.Item2;
        }
    } 
}
