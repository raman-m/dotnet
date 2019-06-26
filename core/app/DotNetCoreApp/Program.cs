using System;
using System.Collections.Generic;

namespace DotNetCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".NET Core Console App");

            Zip.Run();

            Algorithm.RunTripleFibonacci();
        }
    }
}
