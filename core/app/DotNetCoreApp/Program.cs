using System;

namespace DotNetCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".NET Core Console App\nTo exit press 'Q'");

            while (true)
            {
                Console.Write("\nInput: ");
                var input = Console.ReadLine();
                var zip = new Zip();

                var output = zip.Compress(input);

                Console.WriteLine($"Output: '{output}'");
                var key = Console.ReadKey();
                if (key.KeyChar == 'Q')
                    return;
            }
        }
    }
}
