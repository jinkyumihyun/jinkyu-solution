using Speakers.Classes;
using Speakers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Speakers.Interfaces.ILanguageOption;

namespace Speakers.Classes
{
    public class ExtendedWordsFactory : WordsFactory
    {
        public new AbstractWords Get(string words, AbstractSpeaker speaker, AbstractSpeaker hearer, LanguageOption language)
        {
            var languageWords = base.Get(words, speaker, hearer, language);
            if (languageWords is NullWords)
            {
                languageWords = languageWords.Language switch
                {
                    LanguageOption.Japanese => new JapaneseWords(words, speaker, hearer),
                    LanguageOption.Chinese => new ChineseWords(words, speaker, hearer),
                    _ => new NullWords(languageWords.Language)
                };
            }
            return languageWords;
        }
    }
}