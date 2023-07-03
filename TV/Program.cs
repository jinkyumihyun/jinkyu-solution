using TV.Classes;
using static TV.Interfaces.ITVState.TVChannel;
namespace TV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design patterns: State");
            Test();
        }

        static void Test()
        {
            var tv = new TVMachine();
            tv.TurnOn();
            tv.ChangeChannels(ChannelThree);
            tv.ChangeChannels(ChannelOne);
            tv.ChangeChannels(ChannelNine);
            tv.TurnOff();
            tv.ChangeChannels(ChannelOne);
            tv.TurnOn();
            tv.ChangeChannels(ChannelNine);
            tv.ChangeChannels(ChannelThree);
        }
    }
}