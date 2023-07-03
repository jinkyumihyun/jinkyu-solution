namespace HelperLib
{
    public static class Helper
    {
        public static bool Write(string msg, bool retVal = true)
        { if (!string.IsNullOrWhiteSpace(msg)) { Console.WriteLine(msg); } return retVal; }
        public static string? IsNullWhite(string str) => string.IsNullOrWhiteSpace(str) ? null : str;
        public static bool IsNullWhiteBool(string str) => string.IsNullOrWhiteSpace(str);
        public static int? IsZeroNegative(int number) => number <= 0 ? null : number;

        public static T? IsDefined<T>(T e) where T : Enum
        {
            return (!Enum.IsDefined(e.GetType(), e)) ? default : e;
        }
        public static bool Do(Action action, bool retVal = true) { action(); return retVal; }
        public static char GetSelectingChar(string? str, char defaultChar = 'x')
              => string.IsNullOrWhiteSpace(str) ? defaultChar : str.Trim().ToLowerInvariant()[0];
        public static string GetSelectingStr(string? str, string defaultStr = "")
            => string.IsNullOrWhiteSpace(str) ? defaultStr : str.Trim();
        public static object Check(object obj, string msg) => obj is not null ? obj
            : throw new ArgumentNullException(nameof(obj), msg);
        public static string CheckStr(string str, string msg) => !string.IsNullOrWhiteSpace(str) ? str
           : throw new ArgumentException(nameof(str), msg);

        public static char GetSelection(char[] selectors, string msg)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(msg);
                char selection = Helper.GetSelectingChar(Console.ReadLine());
                if (selectors.Contains(selection))
                {
                    return selection;
                }
                Console.WriteLine($"wrong selection char: {selection}.  Press a key.");
                Console.ReadKey();

            }
        }
        public static T NullCheck<T> (T obj) where T : class
        {
            return obj is not null ? obj : throw new ArgumentNullException(nameof(obj));
        }
    }
}
  