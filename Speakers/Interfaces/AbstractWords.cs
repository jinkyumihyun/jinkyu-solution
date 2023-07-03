using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Speakers.Interfaces.AbstractSpeaker;
using static Speakers.Interfaces.ILanguageOption;

namespace Speakers.Interfaces
{
    public abstract class AbstractWords 
    {
        public string Words { get; }
        public AbstractSpeaker Speaker { get; }
        public AbstractSpeaker Hearer { get; }
        public LanguageOption Language { get; }

        protected AbstractWords(string words, AbstractSpeaker speaker, AbstractSpeaker hearer, LanguageOption language)
        {
            Words = words;
            Speaker = speaker;
            Hearer = hearer;
            Language = language;
        }
    }
}
//use Abstract instead of interface
