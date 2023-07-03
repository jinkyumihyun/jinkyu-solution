using Speakers.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Speakers.Interfaces.ILanguageOption;
using Speakers.Classes;
using HelperLib;

namespace Speakers.Classes
{
    public class WordsFactory : IWordFactory
    {
        public AbstractWords Get(string words, AbstractSpeaker speaker, AbstractSpeaker hearer, LanguageOption language) =>
            (Helper.IsNullWhite(words), speaker, hearer, IsLanguageOption(language)) switch
            {
                (null, _, _, _) => throw new ArgumentException(nameof(words)),
                (_, null, _, _) => throw new ArgumentNullException(nameof(speaker)),
                (_, _, null, _) => throw new ArgumentNullException(nameof(hearer)),
                (_, _, _, null) => throw new ArgumentException(nameof(words)),
                (_, _, _, _) => language switch
                    {
                        LanguageOption.English => new EnglishWords(words, speaker, hearer),
                        LanguageOption.French => new FrenchWords(words, speaker, hearer),
                        LanguageOption.German => new GermanWords(words, speaker, hearer),
                        LanguageOption.Korean => new KoreanWords(words, speaker, hearer),
                        _ => new NullWords(language)
                    }
            };
        static LanguageOption? IsLanguageOption(LanguageOption option) => Enum.IsDefined<LanguageOption>(option) ? option : null;
    }
}
