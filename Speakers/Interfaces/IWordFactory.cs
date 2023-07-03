using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Speakers.Interfaces.ILanguageOption;

namespace Speakers.Interfaces
{
    public interface IWordFactory
    {
        AbstractWords Get(string words, AbstractSpeaker speaker, AbstractSpeaker hearer, LanguageOption language);
    }
}
