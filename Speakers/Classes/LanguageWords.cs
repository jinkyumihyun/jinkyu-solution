using Speakers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Speakers.Interfaces.AbstractSpeaker;
using static Speakers.Interfaces.ILanguageOption;

namespace Speakers.Classes
{
    public class EnglishWords : AbstractWords
    {
        //Here, each LanguageWords can have its specific members not represented in AbstractWords
        public EnglishWords(string words, AbstractSpeaker speaker, AbstractSpeaker hearer)
            : base(words, speaker, hearer, LanguageOption.English) {}      
    }
    public class FrenchWords : AbstractWords
    { 
        public FrenchWords(string words, AbstractSpeaker speaker, AbstractSpeaker hearer)
            : base(words, speaker, hearer, LanguageOption.French) {  }
    }
    public class GermanWords : AbstractWords
    {
        public GermanWords(string words, AbstractSpeaker speaker, AbstractSpeaker hearer)
            : base(words, speaker, hearer, LanguageOption.German) { }
    }

    public class KoreanWords : AbstractWords
    {
        public KoreanWords(string words, AbstractSpeaker speaker, AbstractSpeaker hearer)
            : base(words, speaker, hearer, LanguageOption.Korean) {  }
    }
    public class JapaneseWords : AbstractWords
    {
        public JapaneseWords(string words, AbstractSpeaker speaker, AbstractSpeaker hearer)
            : base(words, speaker, hearer, LanguageOption.Japanese) { }
    }
    public class ChineseWords : AbstractWords
    {
        public ChineseWords(string words, AbstractSpeaker speaker, AbstractSpeaker hearer)
            : base(words, speaker, hearer, LanguageOption.Chinese) { }
    }

}
