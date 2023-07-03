using Speakers.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Speakers.Interfaces.ILanguageOption;

namespace Speakers.Interfaces
{
    public abstract class AbstractSpeaker
    {
        protected AbstractSpeaker(string name, LanguageOption option)
            => (Name, Language) = (name, option);
        public string Name { get; }
        public LanguageOption Language { get; }
        public AbstractTranslator Translator { get; private set; }
        public bool Register(AbstractTranslator translator)
        {
             if (! translator.Languages.Contains(Language))
            {
                throw new Exception("AbstractSpeaker.Register translator");
            }
            if (Translator is null)
            {
                Translator = translator;
                return Translator.Register(this);
            }
            return true;
        }
        public abstract string Speak(string words, AbstractSpeaker name);
        public abstract AbstractWords Receive(AbstractWords words);
      
    }
}
