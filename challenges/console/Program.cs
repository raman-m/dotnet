using RamanM.DotNet.Challenges;
using RamanM.DotNet.Challenges.Console;
using System.Reflection;

var asm = Assembly.GetExecutingAssembly();
var solutionName = asm.GetName().Name.Replace(".", " ");

Console.WriteLine($"Welcome to '{solutionName}' app!");

while (true)
{
    Zip.Run();
    if (ConsoleUtils.AskQuit())
        break;
}

Algorithm.RunTripleFibonacci(1);
