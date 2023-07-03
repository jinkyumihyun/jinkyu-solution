using HelperLib;
using Speakers.Classes;
using static Speakers.Interfaces.AbstractSpeaker;
using static Speakers.Interfaces.ILanguageOption;

namespace Speakers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design pattern: Mediator\n");
            Test();
        }
            static void Test() 
        {
            var wordsFactory = new ExtendedWordsFactory();
            var John = Speaker.Create("John", LanguageOption.English, wordsFactory);
            var Giovanni = Speaker.Create("Giovanni", LanguageOption.French, wordsFactory);
            var Kim = Speaker.Create("Kim", LanguageOption.English, wordsFactory);
            var Jinkyu = Speaker.Create("Jinkyu", LanguageOption.Korean, wordsFactory);
            var Hans = Speaker.Create("Hans", LanguageOption.German, wordsFactory);

            var James = Translator.Create("James", LanguageOption.Korean, LanguageOption.English, wordsFactory);
            var Ethel = Translator.Create("Ethel", LanguageOption.English, LanguageOption.French, wordsFactory);
            var Joy = Translator.Create("Joy", LanguageOption.French, LanguageOption.German, wordsFactory);
            var Bucks = Translator.Create("Bucks", LanguageOption.German, LanguageOption.Korean, wordsFactory);

            James.Register(Ethel);
            Ethel.Register(Joy);
            Joy.Register(Bucks);
            Bucks.Register(James);

            James.Register(John);
            Ethel.Register(Giovanni);
            Joy.Register(Hans);
            Bucks.Register(Jinkyu);
            James.Register(Kim);

            John.Speak("How are you?", Hans);
            Console.WriteLine();
            Hans.Speak("I am fine.", John);
            Console.WriteLine();

            Jinkyu.Speak("I want to be employed.", Giovanni);
            Console.WriteLine();
            Giovanni.Speak("You will be OK.", Jinkyu);
            Console.WriteLine();

            Speaker e = (Speaker)Ethel;
            e.Register(James);
            e.Speak("Hey, Hans. Come here quick.", Hans);
            Console.WriteLine();
            Hans.Speak("Ok.  wait a sec.", e);
        }
    }
}