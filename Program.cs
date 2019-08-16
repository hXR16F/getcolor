using System;

namespace getcolor
{
    class Program
    {
        public static string bgColorCode = "null"; public static string fgColorCode = "null";

        static void Main(string[] args)
        {
            ConsoleColor bgColor = Console.BackgroundColor; ConsoleColor fgColor = Console.ForegroundColor;

            if (Convert.ToString(bgColor) == "Black") { bgColorCode = "0"; }
            if (Convert.ToString(bgColor) == "DarkBlue") { bgColorCode = "1"; }
            if (Convert.ToString(bgColor) == "DarkGreen") { bgColorCode = "2"; }
            if (Convert.ToString(bgColor) == "DarkCyan") { bgColorCode = "3"; }
            if (Convert.ToString(bgColor) == "DarkRed") { bgColorCode = "4"; }
            if (Convert.ToString(bgColor) == "DarkMagenta") { bgColorCode = "5"; }
            if (Convert.ToString(bgColor) == "DarkYellow") { bgColorCode = "6"; }
            if (Convert.ToString(bgColor) == "Gray") { bgColorCode = "7"; }
            if (Convert.ToString(bgColor) == "DarkGray") { bgColorCode = "8"; }
            if (Convert.ToString(bgColor) == "Blue") { bgColorCode = "9"; }
            if (Convert.ToString(bgColor) == "Green") { bgColorCode = "a"; }
            if (Convert.ToString(bgColor) == "Cyan") { bgColorCode = "b"; }
            if (Convert.ToString(bgColor) == "Red") { bgColorCode = "c"; }
            if (Convert.ToString(bgColor) == "Magenta") { bgColorCode = "d"; }
            if (Convert.ToString(bgColor) == "Yellow") { bgColorCode = "e"; }
            if (Convert.ToString(bgColor) == "White") { bgColorCode = "f"; }

            if (Convert.ToString(fgColor) == "Black") { fgColorCode = "0"; }
            if (Convert.ToString(fgColor) == "DarkBlue") { fgColorCode = "1"; }
            if (Convert.ToString(fgColor) == "DarkGreen") { fgColorCode = "2"; }
            if (Convert.ToString(fgColor) == "DarkCyan") { fgColorCode = "3"; }
            if (Convert.ToString(fgColor) == "DarkRed") { fgColorCode = "4"; }
            if (Convert.ToString(fgColor) == "DarkMagenta") { fgColorCode = "5"; }
            if (Convert.ToString(fgColor) == "DarkYellow") { fgColorCode = "6"; }
            if (Convert.ToString(fgColor) == "Gray") { fgColorCode = "7"; }
            if (Convert.ToString(fgColor) == "DarkGray") { fgColorCode = "8"; }
            if (Convert.ToString(fgColor) == "Blue") { fgColorCode = "9"; }
            if (Convert.ToString(fgColor) == "Green") { fgColorCode = "a"; }
            if (Convert.ToString(fgColor) == "Cyan") { fgColorCode = "b"; }
            if (Convert.ToString(fgColor) == "Red") { fgColorCode = "c"; }
            if (Convert.ToString(fgColor) == "Magenta") { fgColorCode = "d"; }
            if (Convert.ToString(fgColor) == "Yellow") { fgColorCode = "e"; }
            if (Convert.ToString(fgColor) == "White") { fgColorCode = "f"; }

            Console.WriteLine("0x"
                + bgColorCode + fgColorCode
                + ":"
                + bgColor
                + ":"
                + fgColor);
        }
    }
}
