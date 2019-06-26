using System;
using System.IO;
using System.Text;

namespace DotNetCoreApp
{
    public class Zip
    {
        public string Compress(Stream stream)
        {
            // 1. Open file
            return string.Empty;
        }

        public string Compress(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }

            var builder = new StringBuilder(input.Length);
            int i = 0;
            while (i <= input.Length - 1)
            {
                var j = i;
                char ch = input[i],
                    nextCh = ch;
                while (ch == nextCh && j++ < input.Length - 1)
                {
                    nextCh = input[j];
                }
                if (j - i > 1)
                {
                    builder.Append(j - i);
                }
                
                builder.Append(ch);
                i = j;
            }
            return builder.ToString();
        }

        public static void Run()
        {
            Console.WriteLine("\nString Zip utility");

            while (true)
            {
                Console.Write("\nInput: ");
                var input = Console.ReadLine();

                var zip = new Zip();
                var output = zip.Compress(input);

                Console.WriteLine($"Output: '{output}'");
                if (ConsoleUtils.AskQuit())
                    return;
            }
        }
    }
}