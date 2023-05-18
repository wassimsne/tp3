

namespace tp3.StringExtension
{
    public static  class StringExt
    {
        public static void dump(this string str, ConsoleColor color = ConsoleColor.White)
        {
            if (str != null)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(str);
            }

        }
    }
}
