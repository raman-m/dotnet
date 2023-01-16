using RamanM.DotNet.Challenges;
using RamanM.DotNet.Challenges.Console;

Console.WriteLine("Challenges Demo App");

while (true)
{
    Zip.Run();
    if (ConsoleUtils.AskQuit())
        break;
}

Algorithm.RunTripleFibonacci(1);
