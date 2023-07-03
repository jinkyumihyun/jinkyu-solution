using Speakers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Speakers.Interfaces.ILanguageOption;

namespace Speakers.Classes
{
    public class NullWords : AbstractWords
    {
        public NullWords(LanguageOption language) : base(null, null, null, language) { }
    }
}
