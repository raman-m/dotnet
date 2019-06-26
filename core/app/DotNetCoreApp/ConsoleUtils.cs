using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreApp
{
    public static class ConsoleUtils
    {
        public static bool AskQuit()
        {
            const string message = "To exit press 'Q'";
            Console.Write(message);

            var key = Console.ReadKey();
            if (key.KeyChar == 'Q')
            {
                ClearLine(message.Length + 1);
                Console.Write("Quitting...");
                return true;
            }

            ClearLine(message.Length);
            return false;
        }

        public static void ClearLine(int length)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', ++length));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
}
