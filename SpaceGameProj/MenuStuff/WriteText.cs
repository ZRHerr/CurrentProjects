using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameProj
{
    class WriteText
    {
        internal static void WriteLine(string text, ConsoleColor foregound, ConsoleColor background)
        {
            Console.ForegroundColor = foregound;
            Console.BackgroundColor = background;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        internal static void WriteLine(string text, ConsoleColor foreground)
        {
            Console.ForegroundColor = foreground;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        internal static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
        internal static void Write(string text, ConsoleColor foregound, ConsoleColor background)
        {
            Console.ForegroundColor = foregound;
            Console.BackgroundColor = background;
            Console.Write(text);
            Console.ResetColor();
        }
        internal static void Write(string text, ConsoleColor foreground)
        {
            Console.ForegroundColor = foreground;
            Console.Write(text);
            Console.ResetColor();
        }
        internal static void Write(string text)
        {
            Console.Write(text);
        }

    }
}
