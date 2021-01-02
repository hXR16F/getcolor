using System;

namespace getcolor
{
    class Program
    {

        public static string ToHex(int value)
        {
            return String.Format("{0:X}", value);   
        }

        static void Main(string[] args)
        {
            ConsoleColor bgColor = Console.BackgroundColor;
            ConsoleColor fgColor = Console.ForegroundColor;

            string bgColorCode = ToHex(bgColor.GetHashCode());
            string fgColorCode = ToHex(fgColor.GetHashCode());

            Console.WriteLine( 
                String.Format("0x{0}:{1}:{2}", bgColorCode+fgColorCode, bgColor, fgColor) 
            );
        }
    }
}
